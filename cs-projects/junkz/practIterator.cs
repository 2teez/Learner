using System;
using System.Collections.Generic;

public delegate void Printer(object obj);

class PraticeIterator
{
    static void Main(string[] args)
    {
        var ppl = new Person[] {
            new Person(), new Person{}, new Person()
        };

        IEnumerable<Person> person = new List<Person>(ppl);
        IEnumerator<Person> iter = person.GetEnumerator();
        while (iter.MoveNext())
        {
            iter.Current.Pp();
        }
        var fileWriter = new System.IO.StreamWriter("newFile.dot");
        "Hello, World....".Pp(fileWriter.WriteLine, "Another", "world", "is here");
        fileWriter.Close();
    }
}

static class ObjectUtil
{
    private static void DefaultPrinter(this object obj)
    {
        Console.WriteLine(obj);
    }
    public static void Pp(this object obj, Action<object> fn = null, params string[] values)
    {
        fn ??= DefaultPrinter;
        fn(obj);
        fn(string.Join(" ", values));
    }
}

class Person
{
    public string Name { get; set; } = "John Doe";
    public int Age { get; set; } = 23;
    public override string ToString() => $"Person(Name: {Name}, Age: {Age})";
}
