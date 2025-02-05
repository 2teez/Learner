using System;
using System.Threading.Tasks;


namespace Loggers
{
    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(
                $"{DateTime.Now:T} [{Thread.CurrentThread.ManagedThreadId:00}] {message}");
        }
    }
}
