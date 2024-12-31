using System;
using System.Collections;

class CollectionTest
{
    static void Main(string[] args)
    {
        var animals = new Animal[] { new Cow("fernenard - the bull"),
                                     new Chicken("Geminma - the chicken") };
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
            animal.Feed();
            switch (animal.Name)
            {
                case var name when name.Contains("Geminma"):
                    ((Chicken)animal).LayEgg();
                    break;
                default:
                    ((Cow)animal).Milk();
                    break;
            }
        }  // endforeach
        ArrayList animalsAL = new ArrayList();  // not type-safe
        animalsAL.Add(new Cow("Joey"));
        animalsAL.Add(new Chicken("Johnsony"));
        foreach (var animal in animalsAL)
        {
            Console.WriteLine(animal);
        }
        ((Chicken)animalsAL[animalsAL.Count - 1]).LayEgg();
    }
}

abstract class Animal
{
    protected string name;
    public string Name { get => this.name; set { this.name = value; } }
    public Animal(string name) => this.name = name;
    public virtual void Feed() => Console.WriteLine($"{name} has been fed");
}

class Cow : Animal
{
    public Cow(string name) : base(name) { }
    public void Milk() => Console.WriteLine($"{name} has been milked!");
}

class Chicken : Animal
{
    public Chicken(string name) : base(name) { }
    public void LayEgg() => Console.WriteLine($"{name} has layed an egg!");
}
