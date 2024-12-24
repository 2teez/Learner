using System;

class MethodDemo
{
    static void Main(string[] args)
    {
        doIt();
        doIt();
        MethodDemo md  = new MethodDemo();
        md.DoItAgain();
        md.DoItAgain();
    }
    static void doIt()
    {
        Console.WriteLine("Hello");
    }
    void DoItAgain()
    {
        Console.WriteLine("World!");
    }
}
