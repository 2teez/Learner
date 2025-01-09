using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericDemo
{
    class GenericDemoTest
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal> { new Cow { }, new Chicken("Gemima") };
            foreach (var animal in animals)
            {
                Console.Write($"{animal} ");
                animal.Feed();
            }
        }
    }

    interface Animal
    {
        void Feed();
    }

    class Cow : Animal
    {
        public void Feed() => Console.WriteLine("Eat Straw....");
        public override string ToString() => $"{this.GetType().Name}";
    }

    class Chicken : Animal
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
