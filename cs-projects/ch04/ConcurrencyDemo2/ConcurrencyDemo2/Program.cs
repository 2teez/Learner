using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConcurrencyLibDemo2;

namespace ConcurrencyDemo;

class Program
{
    static async Task Main(string[] args)
    {
        var tasks = new List<Task>();
        var rand = new Random();
        tasks.Add(Task.Run(() => Console.WriteLine(Calculate.Fibonacci(rand.Next(1, 5)))));
        tasks.Add(Task.Run(() => Console.WriteLine(Calculate.Fibonacci(rand.Next(1, 25)))));
        tasks.Add(Task.Run(() => Console.WriteLine(Calculate.Fibonacci(rand.Next(1, 15)))));
        tasks.Add(Task.Run(() => Console.WriteLine(Calculate.Fibonacci(rand.Next(1, 35)))));
        await Task.WhenAll(tasks);
    }
}
