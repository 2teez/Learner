using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SystemExt
{
    static class SystemExtension
    {
        //void Print() { }
        public static void PrintLine<T>(this System.IO.TextWriter t, params T[] data)
        {
            foreach (var d in data)
            {
                t.WriteLine(d);
            }
        }
    }
}

namespace GenericDemo
{
    using SystemExt;
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

    class Cow : IAnimal
    {
        public void Feed() => Console.WriteLine("Eat Straw....");
        public override string ToString() => $"{this.GetType().Name}";
    }

    class Chicken : IAnimal
    {
        private string? name = null;
        public Chicken(string name)
        {
            this.name = name;
        }
        public Chicken() : this("Generic Chicken") { }
        public void Feed() => Console.WriteLine("picking...");
        public override string ToString() => $"{this.GetType().Name}";
    }
}
