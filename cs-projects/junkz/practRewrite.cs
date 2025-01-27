using System;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using Util;

namespace RewriteScript
{
    class Program
    {
        static void Main(string[] args)
        {
            "You are re-writing your program file".Pp(msg: "");
            "Will you to write to a file or just DISPLAY?".Pp(msg: "");
            "1. Display".Pp(msg: "");
            "2. Save to file".Pp(msg: "");
            "3. Save to a default file by this program".Pp(msg: "");
            var choice = int.Parse(GetInput("Choice: "));

            // when file to write is the option selected
            StreamWriter writeToFile = null;
            if (choice == 2)
            {
                writeToFile = new StreamWriter(GetInput("Enter filename to write to: "));
            }
            else if (choice == 3)
            {
                var newfile = "REW";
                writeToFile = new StreamWriter(newfile);
            }

            // read from file
            var readFromFile = GetFile(GetInput("Filename to Read from: "));
            var sb = new StringBuilder();
            while (!readFromFile.EndOfStream)
            {
                sb.Append(Stringify(readFromFile.ReadLine()) + "\n");
            }
            readFromFile.Close();
            if (choice == 1) sb.ToString().Pp(msg: "");
            else
            {
                sb.ToString().Pp(writeToFile.WriteLine, msg: "");
                writeToFile.Close();
            }
        }

        /// Comments
        public static string Stringify(string line)
        {
            if (Regex.IsMatch(line, "/// Comments$"))
            {
                return $@"
                /// <summary>
                /// </summary>
                /// <param name=""> </param>
                /// <returns> </returns>
                /// <example>
                /// <code> </code>
                /// </example>
                ";
            }
            return line;
        }
        /// Comments
        public static StreamReader GetFile(string filename)
        {
            StreamReader file = null;
            try
            {
                file = new StreamReader(filename);
            }
            catch (Exception ex)
            {
                ex.Message.Pp(msg: $"Error: {filename} is Invalid.");
            }
            return file;
        }
        /// Comments
        public static string GetInput(string msg = "Enter: ")
        {
            msg.Pp(Console.Write, msg: "");
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
        /// Comments
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
        /// Comments
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
