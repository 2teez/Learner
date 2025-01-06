using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CollectThem
{
    class CollectionsTest
    {
        static void Main(string[] args)
        {
            var persons = new Person[]
            {
                new Person("javascript", 30),
                new Person("rust", 10),
                new Person("perl", 40),
            };
            var people = new People();
            people.Add(new Person("java", 35));
            Console.WriteLine(people.Count);
            people.AddRange(persons);
            Console.WriteLine(people.Count);
            Console.WriteLine(people.GetOldest());
        }
    }
    partial class Person
    {
        public static bool operator >(Person p1, Person p2) => p1.Age > p2.Age;
        public static bool operator >=(Person p1, Person p2) => p1.Age > p2.Age || p1.Age == p2.Age;
        public static bool operator <(Person p1, Person p2) => p1.Age < p2.Age;
        public static bool operator <=(Person p1, Person p2) => p1.Age < p2.Age || p1.Age == p2.Age;
    }
    class People : DictionaryBase, ICloneable
    {
        public void Add(Person person) { Dictionary.Add(person.Name, person); }
        public void AddRange(Person[] persons)
        {
            foreach (var person in persons)
            {
                if (!Dictionary.Contains(person.Name))
                {
                    Dictionary.Add(person.Name, person);
                }
            }
        }
        public Person this[string name]
        {
            get => (Person)Dictionary[name];
            set => Dictionary[name] = value;
        }
        public void Remove(string name)
        {
            Dictionary.Remove(name);
        }
        public Person GetOldest()
        {
            var name = "";
            var age = 0;
            foreach (DictionaryEntry entry in this)
            {
                if (((Person)entry.Value).Age > age)
                {
                    name = (string)entry.Key;
                }
            }
            return this[name];
        }

        public object Clone()
        {
            var newPeople = new People();
            foreach (DictionaryEntry p in this)
            {
                newPeople.Dictionary.Add(p.Key, p.Value);
            }
            return newPeople;
        }
        public IEnumerator<Person> GetEnumerator()
        {
            foreach (DictionaryEntry p in this)
            {
                yield return ((Person)p).Value;
            }
        }

    }
    class APeople : CollectionBase
    {
        public void Add(Person person) { List.Add(person); }
        public Person this[int index]
        {
            get => (Person)List[index];
            set => List[index] = value;
        }
        public void Remove(Person person)
        {
            List.Remove(person);
        }
    }
    partial class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public override string ToString() => $"Person{{{Name}, {Age}}}";
    }
}
