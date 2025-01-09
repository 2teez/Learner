using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using SystemExt;


namespace GenericDemo
{
    class GenericDemoTest
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal> { new Cow { }, new Chicken("Gemima") };
            foreach (var animal in animals)
            {
                Console.Write($"{animal} ");
                animal.Feed();
            }
            PrintCollections(animals);
        }

        static void PrintCollections<T>(IEnumerable<T> collections)
        {
            foreach (var collection in collections)
            {
                Console.Out.PrintLine(collection);
            }
        }
    }

    interface IAnimal
    {
        void Feed();
    }

    abstract class Animal : IAnimal
    {
        public abstract void Feed();
        public override bool Equals(object? obj)
        {
            if (obj is Animal)
            {
                return obj?.GetType().Name == this.GetType().Name;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (this.GetType().FullName?.Length ?? 5) * this.GetHashCode();
        }
        public override string ToString() => $"{this.GetType().Name}";
    }

    class Cow : Animal
    {
        public override void Feed() => Console.WriteLine("Eat Straw....");
    }

    class Chicken : Animal
    {
        private string? name = null;
        public Chicken(string name)
        {
            this.name = name;
        }
        public Chicken() : this("Generic Chicken") { }
        public override void Feed() => Console.WriteLine("picking...");
    }
}
