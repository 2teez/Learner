using System;
using System.Threading;
using System.Threading.Tasks;

using TaskDemoLogger;

namespace Ch05.Exercise.Exercise02;

class Program
{
    public static void Main(string[] args)
    {
        Logger.Log("Starting...");
        var taskA = Task.Run(() =>
        {
            Logger.Log("Starting Task A");
            Thread.Sleep(TimeSpan.FromSeconds(3D));
            Logger.Log("Leaving Task A");
            return "All task A done!";
        });
        var taskB = Task.Run(TaskBActivity);
        var taskC = Task.Run(TaskCActivity);

        var timeout = TimeSpan.FromSeconds(new Random().Next(1, 10));
        Logger.Log($"Waiting max {timeout.TotalSeconds} seconds...");
        var allDone = Task.WaitAll(new[] { taskA, taskB, taskC }, timeout);
        Logger.Log(
            $"AllDone={allDone}: TaskA={taskA.Status}, TaskB={taskB.Status}, TaskC={taskC.Status}");
        Console.WriteLine("Press ENTER to exit.");
        Console.ReadKey();
    }

    private static string TaskBActivity()
    {
        Logger.Log($"Starting {nameof(TaskBActivity)}");
        Thread.Sleep(TimeSpan.FromSeconds(1D));
        Logger.Log($"Leaving {nameof(TaskBActivity)}");
        return "";
    }

    private static void TaskCActivity()
    {
        Logger.Log($"Starting {nameof(TaskCActivity)}");
        Thread.Sleep(TimeSpan.FromSeconds(2D));
        Logger.Log($"Leaving {nameof(TaskCActivity)}");
    }
}
