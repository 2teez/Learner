
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; } = "Person";
    public int Age { get; set; } = 12;
    public override string ToString() => $"Person{{{Name}, {Age}}}";
}

class People
{
    private Dictionary dict;
    public People()
    {
        dict = new Dictionary<string, Person>();
    }
    public void Add(Person person) => dict.Add(person.Name, person);
    public void Remove(Person person) => dict.Remove(person);
    public Person this[string name]
    {
        get => dict[name];
        set => dict[name] = value;
    }
}
