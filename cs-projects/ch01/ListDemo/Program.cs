using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class ListDemo
{
    static void Main(string[] args)
    {
        var persons = new List<Person> { Person.MakePerson("john", 34), Person.MakePerson("clojure", 25) };
        persons.Add(Person.MakePerson("javascript", 30));
        persons.Add(Person.MakePerson("cobol", 40));

        PrintEnumerable(persons);
        persons.Remove(persons[0]);
        PrintEnumerable(persons);
        Console.WriteLine(persons[0].Equals(persons[persons.Count - 1]));
        persons.AddRange(new Person[] { Person.MakePerson("erlang", 20), Person.MakePerson("perl", 30) });
        PrintEnumerable(from person in persons where person.Age > 25 orderby person.Name select person);
        PrintEnumerable(from person in persons
                        let nameInUpper = person.Name.ToUpper()
                        orderby nameInUpper descending
                        select new { person.Age, nameInUpper }
                        );
        Console.WriteLine("Capacity: " + persons.Capacity);
    }

    static void PrintEnumerable<T>(IEnumerable<T> values, string msg = "Values: ")
    {
        foreach (var value in values)
        {
            Console.Write($"{value,3} \n");
        }
        Console.WriteLine();
    }
}

class Person
{
    public string name;
    public int age;
    private Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get => this.name; set => this.name = value; }
    public int Age { get => this.age; set => this.age = value; }
    public static Person MakePerson(string name, int age) => new Person(name, age);
    public override string ToString() => $"Person{{Name: {this.name}, Age: {this.age}}}";
}
