#nullable enable

System.Console.Out.PrintLine("Hello, New World");
System.Console.Out.PrintLine<double>(34.67);

var java = new Person { };
System.Console.Out.PrintLine<Person>(java);
java.Name = "Java";
java.Age = 35;
System.Console.Out.PrintLine<Person>(java);

new System.Collections.Generic.List<int>(
    new[] { 2, 5, 8, 4, 0 }).ForEach(n => System.Console.Write(n + " "));//);

struct Person
{
    private string? name;
    private int? age;

    public string Name { get => name ?? "Doe"; set => name = value; }
    public int Age { get => age ?? 0; set => age = value; }
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

    public static void ForEach<T>(this System.Collections.Generic.List<T> list, System.Action<T> fn)
    {
        foreach (var value in list)
        {
            fn(value);
        }
        System.Console.WriteLine();
    }
}
