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

            List<string> newStuff = new List<string> {
                "bread", "milk", "coffee", "umberalla", "shoes"};

            ShortList<string> items = new ShortList<string>(newStuff);
            //items.Add("bread");
            newStuff.ForEach(n => Console.WriteLine(n));
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
        private List<T> items;
        private readonly int capacity;
        public ShortList(IEnumerable<T> nitems, int size = 5)
        {
            var innerItems = new List<T>(nitems);
            if (innerItems.Count > size)
                throw new IndexOutOfRangeException("out of range error");
            items = new List<T>(size);
            foreach (var item in nitems) items.Add(item);
            capacity = size;
        }
        public T this[int index]
        {
            get => (T)items[index];
            set => items[index] = value;
        }
        public void Add(T item)
        {
            Console.WriteLine(capacity);
            if (items.Count >= capacity)
                throw new IndexOutOfRangeException("out of range error");
            items.Add(item);
        }

        public void Insert(int index, T item)
        {
            if (index > items.Count)
                throw new IndexOutOfRangeException("out of range error");
            items.Insert(index, item);
        }
        public int IndexOf(T item) => items.IndexOf(item);
        public bool Remove(T item) => items.Remove(item);
        public void RemoveAt(int index) => items.RemoveAt(index);
        public int Count => items.Count;
        public void Clear() => items.Clear();
        public bool Contains(T item) => items.Contains(item);
        public void CopyTo(T[] aitems, int startIndex) => items.CopyTo(aitems, startIndex);
        public bool IsReadOnly { get; set; } = false;
        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
