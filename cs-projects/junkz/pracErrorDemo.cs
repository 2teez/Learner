using System;

int result = 0, denominator = 0;
try
{
    if (denominator == 0) throw new MyError();
    result = 4 / denominator;
}
catch (MyError me)
{
    Console.WriteLine($"What from Error Extension: {me.What()}");
    Console.WriteLine($"Message: {me.Message}");
    Console.WriteLine($"StackTrace: {me.StackTrace}");
    //Console.WriteLine($"InnerException: {me.innerException}");
}
catch (Exception ec)
{
    Console.WriteLine($"What from Error Extension: {ec.What()}");
    Console.WriteLine($"Message: {ec.Message}");
    Console.WriteLine($"StackTrace: {ec.StackTrace}");
    //Console.WriteLine($"InnerException: {ec.innerException}");
}
finally
{
    Console.WriteLine(result);
}


static class ErrorExtension
{
    public static Exception What(this Exception err, string msg = "Error: ")
    {
        return new Exception(msg + err.ToString());
    }
}

class MyError : Exception
{
    private readonly string msg;
    public MyError(string msg = "Error...:") : base(msg)
    {
        this.msg = msg;
    }
}
