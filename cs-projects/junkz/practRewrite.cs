using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Util;

namespace RewriteScript
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var f = new StreamWriter("new.txt");
            "Halleluyah..".Times(500).Pp(f.WriteLine, "Shouting 500 Halleluyahs for Daniel @ 5!");
            f.Close();*/
        }
    }
}

namespace Util
{
    static class Printer
    {
        public static void Pp(
            this object obj,
            Action<object> fn = null,
            string msg = "Printing..")
        {
            fn ??= Console.Out.WriteLine;
            fn(msg);
            fn(obj);
        }
        public static string Times(this string str, int numberOfTimes = 3, string sep = "\n")
        {
            var txt = new System.Text.StringBuilder(numberOfTimes);
            for (var i = 0; i < numberOfTimes; i++)
            {
                txt.Append(str + $" number {i + 1}" + sep);
            }
            return txt.ToString();
        }
    }
}
