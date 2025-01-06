using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class TestThemAll
{
    static void Main(string[] args)
    {
        var persons = new Person[] { new Person("java", 35), new Person("javascript", 32), new Person() };
        var dict = new People();
        dict.AddRange(persons);
        Console.WriteLine("Printing Persons Added:");
        foreach (var person in from p in persons orderby p.Age descending select p)
        {
            Console.WriteLine(person);
        }
    }
}

class Person
{
    public Person(string name = "John Doe", int age = 12)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; } = "Person";
    public int Age { get; set; } = 12;
    public override string ToString() => $"Person{{{Name}, {Age}}}";
}

class People
{
    private Dictionary<string, Person> dict;
    public People()
    {
        dict = new Dictionary<string, Person>();
    }
    public void Add(Person person) => dict.Add(person.Name, person);
    public void AddRange(Person[] persons)
    {
        foreach (var person in persons)
        {
            dict.Add(person.Name, person);
        }
    }
    public void Remove(Person person) => dict.Remove(person.Name);
    public Person this[string name]
    {
        get => dict[name];
        set => dict[name] = value;
    }

    public IEnumerator<Person> GetEnumerator()
    {
        foreach (var person in dict)
        {
            yield return person.Value;
        }
    }
}
