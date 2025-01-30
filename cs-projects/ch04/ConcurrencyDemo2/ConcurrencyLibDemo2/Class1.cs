using System.Collections.Generic;

namespace ConcurrencyLibDemo2;

public class Calculate
{
    public bool GreaterThan<T>(T obj1, T obj2) where T : IComparable => obj1.CompareTo(obj2) > 0;
    public static long Fibonacci(int n) =>
        n <= 2L ? 1L : Fibonacci(n - 2) + Fibonacci(n - 1);

}
