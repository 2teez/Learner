using System;
using System.Threading;
using System.Threading.Tasks;
using TaskDemoLogger;

namespace TaskDemo;

public class Program
{
    public static async Task Main(string[] args)
    {
        Logger.Log("Creating Task A");
        var taskA = new Task(() =>
        {
            Logger.Log("Inside Task A");
            Thread.Sleep(TimeSpan.FromMinutes(0.2D));
            Logger.Log("Leaving Task A");
        });
        Logger.Log($"Starting taskA. Status={taskA.Status}");
        taskA.Start();
        Logger.Log($"Started taskA. Status={taskA.Status}");
        Console.WriteLine();
        /// Another way to do the same thing
        Logger.Log("Creating Task B.");
        var taskB = Task.Factory.StartNew(() =>
        {
            Logger.Log("Inside Task B.");
            Logger.Log($"Starting Task B.");
            Thread.Sleep(TimeSpan.FromSeconds(3D));
            Logger.Log("Leaving task B.");
        });
        Logger.Log($"Started taskB. Status={taskB.Status}");
        Console.WriteLine();
        /// Another way to do the same thing
        Logger.Log("Creating Task C.");
        var taskC = Task.Run(() =>
        {
            Logger.Log("Inside Task C.");
            Logger.Log($"Starting Task C.");
            Thread.Sleep(TimeSpan.FromSeconds(1D));
            Logger.Log("Leaving task C.");
        });
        Logger.Log($"Started taskC. Status={taskB.Status}");
        Console.WriteLine();
        await Task.WhenAll(taskA, taskB, taskC);
        Logger.Log("All task finished.");
    }
}
