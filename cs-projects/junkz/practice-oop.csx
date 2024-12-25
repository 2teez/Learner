
Human adam = new Human("java", 34);
PrintHuman(adam);
adam.Printer();

Human human2 = adam;
human2.name = "eve";
human2.Printer();
adam.Printer();

struct Human
{
    public string name;
    public int age;

    public Human(string iname, int iage)
    {
       name = iname;
       age = iage;
    }

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
