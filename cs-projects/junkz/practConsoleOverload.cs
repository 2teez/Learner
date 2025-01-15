#nullable enable

System.Console.Out.PrintLine("Hello, New World");
System.Console.Out.PrintLine<double>(34.67);

var java = new Person { };
java.Name = "Java";
java.Age = 35;
System.Console.Out.PrintLine<Person>(java);

struct Person
{
    private string name;
    private int age;

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public override string ToString() => $"Name: {Name}, Age: {Age}";
}

public static class Printer
{
    public static void PrintLine(this System.IO.TextWriter writer, object obj)
    {
        writer.WriteLine(obj);
    }

    public static void PrintLine<T>(this System.IO.TextWriter writer, T obj)
    {
        writer.WriteLine(obj);
    }
}
