using System;
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
            System.Collections.ArrayList data = new System.Collections.ArrayList();
            data.AddRange(new object[] { 1, 4, 7, new Gardget("bolier", "to boil"), 4.2, 1.35 });
            string.Join(" ", data.OfType<double>()).Pp();
            string.Join(" ", data.OfType<int>()).Pp();
        }
    }
}

namespace Util
{
    static class Util
    {
        public static void Pp(this object obj) => Console.WriteLine(obj);
    }
}
