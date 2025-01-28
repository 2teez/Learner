using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

using TaskDemoLogger;

namespace Ch05.Exercise.Exercise01
{

    class Program
    {
        public static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Enter a number: ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && int.TryParse(
                    input, NumberStyles.Any, CultureInfo.CurrentUICulture, out var number))
                {
                    Task.Run(() =>
                    {
                        Logger.Log("Starting Fibonacci...");
                        var startTime = DateTime.Now;
                        var result = Fibonacci(number);
                        var endTime = DateTime.Now.Subtract(startTime);
                        Logger.Log(
                            $"Fibonacci {number:N0} = {result:N0} (elpased Time: {endTime.TotalSeconds:N0} secs)");
                    });
                }
            } while (input != string.Empty);
        }
        private static long Fibonacci(int n)
        {
            if (n <= 2L)
            {
                return 1L;
            }
            return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
    }
}
