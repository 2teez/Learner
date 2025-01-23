using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Util;

namespace LinqPractice
{
    record Gardget
    {
        public string Name { get; set; }
        public string Purpose { get; set; }
        public Gardget(string name, string purpose)
        {
            Name = name;
            Purpose = purpose;
        }
        public Gardget() : this("John Doe", "dead") { }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var lists = new List<Gardget> {
                new Gardget { Name = "Perl", Purpose = "text processing..." }
                , new Gardget { Name = "c#", Purpose = "beautiful copy cat.." },
                new Gardget { Name = "Java", Purpose = "rule all oop." } }
            ;
            string.Join(",", lists).Pp();
            string.Join("\n", (from list in lists
                               where list.Purpose.EndsWith(".")
                               orderby list.Purpose
                               select list)).Pp();
            string.Join("\n", (lists.Where(g => !g.Name.StartsWith("c"))
                                    .OrderBy(g => g.Name)
                                    .Select(g => g))).Pp();
            System.Collections.ArrayList data =
                new System.Collections.ArrayList();
            data.AddRange(new object[] { 1, 4, 7, new Gardget(
                "bolier", "to boil"), 4.2, 1.35 });
            string.Join(" ", data.OfType<double>()).Pp();
            string.Join(" ", data.OfType<int>()).Pp();

            string.Join(",", (new object[]{ new { Name= "java", Purpose = "rule all"},
                new {Name="Exclair", Purpose = "sense out"} }).ToArray()).Pp();
            ///
            data.Lpp<System.Collections.ArrayList>();
            ///
            var ndata = string.Join(",", (new object[]{ new { Name= "java", Purpose = "rule all"},
                new {Name="Exclair", Purpose = "sense out"} }));
            ndata.Pp();
        }
    }
}

namespace Util
{
    static class Util
    {
        public static void Pp(this object obj) => Console.WriteLine(obj);
        public static void Lpp<T>(this T obj, string msg = "Values...")
        {
            if (string.IsNullOrEmpty(msg)) Console.WriteLine();
            else Console.WriteLine(msg);
            if (obj is IEnumerable enumerable)
            {
                string.Join(",", enumerable.Cast<object>()).Pp();
            }
            else
            {
                obj.Pp();
            }
        }
    }
}
