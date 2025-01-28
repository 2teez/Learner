using System;
using System.Threading;

namespace TaskDemoLogger;

public static class Logger
{
    public static void Log(string msg)
    {
        Console.WriteLine(
            $"{DateTime.Now:T} [{Thread.CurrentThread.ManagedThreadId:00}] {msg}");
    }
}
