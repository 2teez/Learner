using System;

int result = 0, denominator = 0;
try
{
    if (denominator == 0) throw new MyError();
    result = 4 / denominator;
}
catch (MyError me)
{
    Console.WriteLine(me.What());
}
catch (Exception ec)
{
    Console.WriteLine(ec.What());
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
    public MyError(string msg = "Error...:")
    {
        this.msg = msg;
    }
}
