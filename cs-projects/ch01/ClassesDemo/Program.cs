// See https://aka.ms/new-console-template for more information
using static Util.Util;
using Util;
using static Utility.Util;

Console.WriteLine("Hello, World!");
Console.WriteLine(GetString("Enter your value: "));
Console.WriteLine(UtilC.Instance.GetString());
Console.WriteLine(Instance.GetString("From External Lib: "));
