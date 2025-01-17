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
            langs.PrintIt(Console.Write);
            Console.WriteLine(string.Join(", ", langs));
            Console.WriteLine(LinearSearch(langs, "c#"));
            Console.WriteLine(BinarySearch(values, 8));
        }

        public static void Randomized<T>(ref T[] ienum)
        {
            var rand = new Random();
            var list = new List<T>(ienum);
            var indices = new List<int>();
            while (indices.Count < list.Count)
            {
                var randomNumber = rand.Next(0, list.Count);
                if (indices.Contains(randomNumber))
                    continue;
                else indices.Add(randomNumber);
            }
            // adding the items
            for (var index = 0; index < indices.Count; ++index)
            {
                ienum[index] = list[indices[index]];
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
        public static int BinarySearch<T>(IEnumerable<T> ienum, T searchKey)
        {
            var list = new List<T>(ienum);
            var startIndex = 0;
            var midIndex = (list.Count / 2) + 1;
            ienum.PrintIt(n => Console.Write(n + ","), "Values inside Binary Search:");
            var result = BinarySearch(ienum, startIndex, midIndex, searchKey);
            if (result == -1)
                result = BinarySearch(ienum, midIndex, list.Count - 1, searchKey);
            return result;
        }
        private static int BinarySearch<T>(
            IEnumerable<T> ienum,
            int startIndex, int endIndex, T searchKey)
        {
            var list = new List<T>(ienum);
            for (var i = startIndex; i < endIndex; i++)
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
