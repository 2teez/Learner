using System;
using static System.Console;
var omit = new Person { Name = "omit", Age = 34 };
Console.WriteLine(omit);
omit.GetFullName("java", "jvm");
Console.WriteLine(omit);
WriteLine(new Person { }.Name);

class Person
{
    private string name;
    private int age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public Person() : this("John", 12) { }
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public override string ToString() => $"Person{{{Name}, {Age}}}";
}

static class PersonExtension
{
    public static Person GetFullName(this Person person, string middleName, string lastName)
    {
        person.Name += $" {middleName} {lastName}";
        return person;
    }
}
