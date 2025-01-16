using System;
using System.Collections.Generic;
using static UtlExt.ArrayPrinter;

namespace PractSearching
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateValues(20).PrintIt(n => Console.Write(n + "["));
        }

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
    }
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
        }
    }
}
