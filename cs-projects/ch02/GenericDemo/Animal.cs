
using System;

namespace GenericDemo
{
    public interface IAnimal
    {
        void Feed();
    }

    public abstract class Animal : IAnimal
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

    public class Cow : Animal
    {
        public override void Feed() => Console.WriteLine("Eat Straw....");
    }

    public class Chicken : Animal
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
