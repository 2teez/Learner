using System;
using System.Collections.Generic;
using static UtlExt.ArrayPrinter;

namespace PractSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = GenerateValues(20);
            values.PrintIt(n => Console.Write(n + "]["));
            Console.WriteLine(string.Join(",", values));
            Console.WriteLine(LinearSearch(values, 5));
            var langs = new string[] { "java", "c#", "jquery", "javascript" };
            langs.PrintIt(n => Console.WriteLine(n + ","));
            Console.WriteLine(LinearSearch(langs, "c#"));
            Randomized(ref langs);
            //langs.PrintIt(n => Console.Write(n + ","));
            Console.WriteLine(string.Join(", ", langs));
            Console.WriteLine(LinearSearch(langs, "c#"));
        }

        public static void Randomized<T>(ref T[] ienum)
        {
            var rand = new Random();
            var list = new List<T>(ienum);
            for (var i = 0; i < list.Count; i++)
            {
                ienum[i] = list[rand.Next(list.Count)];
            }
        }  // end of Randomized method
        public static int[] GenerateValues(
            int numberOfValues,
            int numberRange = 10
        )
        {
            Random rand = new Random();
            var values = new int[numberOfValues];
            for (var i = 0; i < numberOfValues; i++)
            {
                values[i] = 1 + rand.Next(numberRange);
            }
            return values;
        }
        public static int LinearSearch<T>(IEnumerable<T> ienum, T searchKey)
        //where T : IComparable
        {
            var list = new List<T>(ienum);
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(searchKey))
                {
                    return (i + 1);
                }
            }
            return -1; // searchKey not found
        }
    } // end of class program
}

namespace UtlExt
{
    static class ArrayPrinter
    {
        public static void PrintIt<T>(
            this IEnumerable<T> ienum,
            Action<T> fn,
            string msg = "Values:"
        )
        {
            Console.WriteLine($"{msg}");
            foreach (var val in ienum)
            {
                fn(val);
            }
            Console.WriteLine();
        }
    }
}
