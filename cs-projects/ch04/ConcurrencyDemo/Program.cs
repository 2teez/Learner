using System;
using Loggers;

namespace ConcurrencyDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Logger.Log("Starting..");
            await BuildGreetings();
            Logger.Log("Ending..");
            Console.WriteLine("Press Enter to Exit.");
            Console.ReadKey();
        }

        static async Task BuildGreetings()
        {
            Logger.Log($"Inside of {nameof(BuildGreetings)}");
            string greetings = "Good Morning..";
            Logger.Log($"{greetings}");

            await Task.Delay(TimeSpan.FromSeconds(10D));
            greetings += ".. Good Afternoon";
            Logger.Log($"{greetings}");

            await Task.Delay(TimeSpan.FromSeconds(1D));
            greetings += ".. Good Evening..";
            Logger.Log($"{greetings}");
        }
    }
}
