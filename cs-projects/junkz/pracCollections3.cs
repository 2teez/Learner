using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectThem
{
    class CollectionsTest
    {
        static void Main(string[] args)
        {


        }
    }

    class People : DictionaryBase
    {
        public void Add(Person person) { Dictionary.Add(person.Name, person.Age); }
        public Person this[string name]
        {
            get => (Person)Dictionary[name];
            set => Dictionary[name] = value;
        }
        public void Remove(string name)
        {
            Dictionary.Remove(name);
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
    class Person
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
