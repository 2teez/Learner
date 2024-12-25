
Human adam = new Human("java", 34);
PrintHuman(adam);
adam.Printer();

Human human2 = adam;
human2.name = "eve";
human2.Printer();
adam.Printer();

Human adam2 = new Human();
adam2.Printer();

Person shazam = new Person(/*name: "Shazam", age: 13*/);
shazam.Printer();

public interface IPrinter
{
    void Printer();
}

struct Human : IPrinter
{
    public string name;
    public int age;

    public Human(string iname, int iage)
    {
       name = iname;
       age = iage;
    }
    public Human(): this(iname:"Joe", iage:23) {}
    public void Printer()
    {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Age: " + this.age);
    }
}

void PrintHuman(Human person)
{
    Console.WriteLine("Name: " + person.name);
    Console.WriteLine("Age: " + person.age);
}

class Person : IPrinter
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public Person(): this(name:"John Doe", age:25) {}
    public void Printer()
    {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Age: " + this.age);
    }
}
