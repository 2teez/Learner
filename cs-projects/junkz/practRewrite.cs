using System;
using System.Text;
using System.Text.RegularExpressions;
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
            /*
            // used to generate some string
            var f = new StreamWriter("new.txt");
            "Halleluyah..".Times(500).Pp(f.WriteLine, "Shouting 500 Halleluyahs for Daniel @ 5!");
            f.Close();
            */
            var file = GetFile(GetInput());
            while (!file.EndOfStream)
            {
                Stringify(file.ReadLine());
            }
            file.Close();
        }
        public static void Stringify(string line)
        {
            if (line == "")
                line.Pp(msg: "");
        }
        public static StreamReader GetFile(string filename)
        {
            StreamReader file = null;
            try
            {
                file = new StreamReader(filename);
            }
            catch (Exception ex)
            {
                ex.Message.Pp();
            }
            return file;
        }
        public static string GetInput(string msg = "Enter: ")
        {
            msg.Pp(msg: "");
            var input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                "Invalid Input".Pp(msg: "");
                input = Console.ReadLine();
            }
            return input;
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
            if (msg != "")
                fn(msg);
            fn(obj);
        }
        public static string Times(this string str, int numberOfTimes = 3, string sep = "\n")
        {
            var txt = new StringBuilder(numberOfTimes);
            for (var i = 0; i < numberOfTimes; i++)
            {
                txt.Append(str + $" number {i + 1}" + sep);
            }
            return txt.ToString();
        }
    }
}
