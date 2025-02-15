using System;
using Util;
using System.Runtime.CompilerServices;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 23, 12, 10, 40 };
            string[][] person = new string[][]
            {
                new []{"james", "java"},
                new []{"eich", "javascript", "emcscript"},
                new []{"larry", "perl"},
                new []{"helgod", "c#"}
            };
            for (var i = 0; i < person.GetLength(0); ++i)
            {
                var fullName = "";
                for (var j = 0; j < person[i].GetLength(0); ++j)
                {
                    fullName += person[i][j] + ", ";
                }
                string.Format("Name: {0} Age: {1}", fullName, ages[i]).Pp();
            }
            // using struct, class or record
            Person[] persons = { new Person ("clojure", "josh", 23),
                new Person("James", "Gostling", 65), new Person(),
                new Person("Larry", "Wall", 55), new Person() };

            foreach (var _person in persons) { _person.Pp(); }
            (persons[0] + persons[2]).Pp();
        }
    }
    //sealed record RPerson(string firstName, string lastName, int Age);
    readonly struct Person
    {
        internal readonly string FirstName { get; }
        internal readonly string LastName { get; }
        internal readonly int Age { get; }
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public static Person operator +(Person p1, Person p2)
        {
            return new Person(p1.FirstName + p2.LastName, p1.LastName, p2.Age);
        }
        //public Person() : this("John", "Doe", 12) { }
        public override string ToString()
        {
            var fullName = string.Format("{1}, {0}", FirstName, LastName);
            return $"Name: {fullName}, Age: {Age}";
        }
    }
}

namespace Util
{
    static class Printer
    {
        public static void Pp(this object obj, Action<object> p = null)
        {
            p ??= Console.WriteLine;
            p(obj);
        }
    }
}

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInt { }
}
