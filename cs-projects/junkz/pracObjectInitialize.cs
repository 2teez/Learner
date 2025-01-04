using System;
using static System.Console;
Console.WriteLine(new Person { Name = "omit", Age = 34 });
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
