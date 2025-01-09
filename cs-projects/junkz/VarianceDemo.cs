#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;

namespace VarianceDemo
{
    class VarianceTestDemo
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow { };
            Animal animal = cow;
            animal.Feed();
        }
    }

    public interface IAnimal
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

    class ShortList<T> : IList<T>
    {
        private const int Capacity = 5;
        private T[] items = new[Capacity];
    }
}
