using static System.Console;
using System.Collections.Generic;
using System.Linq;

class PracTuple
{
    static void Main(string[] args)
    {
        var tup = ("java", "clojure", "elixir", "ruby");
        WriteLine(tup);
        WriteLine(tup.Item3);
        (string java, string csharp, string javascript, string python) tuple =
            ("java", "csharp", "javascript", "python");
        WriteLine($"{tuple.java}, {tuple.javascript}");

        int[] array = new int[] { 6, 2, 9, 4, 8, 3, 1 };
        var statistics = GetStats(array);
        WriteLine(
        $"Min: {statistics.min}, Max: {statistics.max}, Average: {statistics.average:0.00}");
        /// tuple
        (string myName, int myAge) = ("clojure", 12);
        WriteLine($"Name: {myName} -> Age: {myAge}");
    }

    static (int min, int max, double average) GetStats(IEnumerable<int> arr)
    {
        return (Enumerable.Min(arr), Enumerable.Max(arr), Enumerable.Average(arr));
    }
}
