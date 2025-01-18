using System.Collections.Generic;
using Searcher;
using Sorter;

namespace PracticeAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = GenerateNumbers();
            PrintArray(values, n => Console.Write(n + " "), "Before Sorting Items:");
            Sorter.Sorter.Sorted<int>(ref values, Order.Descending);
            PrintArray(values, n => Console.Write(n + " "), "After Sorting Items:");
            Sorter.Sorter.Sorted<int>(ref values);
            PrintArray(values, n => Console.Write(n + " "), "After Sorting Items:");
            /// Sorting used
            var langs = "java,javascript,elixir,c#,erlang,cobol,perl,phython".Split(",");
            PrintArray(langs, n => Console.Write(n + " "), "Before Sorting Items:");
            Sorter.Sorter.Sorted<string>(ref langs, Order.Descending);
            PrintArray(langs, n => Console.Write(n + " "), "After Sorting Items:");
            Sorter.Sorter.Sorted<string>(ref langs);
            PrintArray(langs, n => Console.Write(n + " "), "After Sorting Items in Ascending Order:");
            /// Searcher used
            Console.WriteLine(Searcher.Searcher.BinarySearch<string>(langs, "rust"));
            Console.WriteLine(Searcher.Searcher.BinarySearch<string>(Randomized(langs), "java"));
        }

        public static T[] Randomized<T>(IEnumerable<T> ienum)
        {
            var list = new List<T>(ienum);
            var rand = new Random();
            var newArray = new T[list.Count];
            var count = 0;
            while (count < list.Count)
            {
                var index = rand.Next(list.Count);
                newArray[count++] = list[index];
            }
            return newArray;
        }
        public static void PrintArray<T>(
            IEnumerable<T> ienum, Action<T> fn, string msg = "Values: ")
        {
            Console.WriteLine(msg);
            var list = new List<T>(ienum);
            foreach (var value in ienum)
            {
                fn(value);
            }
            Console.WriteLine();
        }

        public static int[] GenerateNumbers(
            int numberCount = 10,
            int start = 0,
            int stop = 10,
            int step = 1
        )
        {
            if (numberCount < stop)
            {
                numberCount = stop;
            }

            var rand = new Random();
            var count = 0;
            var newArray = new int[numberCount];
            for (var i = start; i < stop; ++i)
            {
                newArray[count++] = rand.Next(start, stop);
            }
            return newArray;
        }
    }
}
