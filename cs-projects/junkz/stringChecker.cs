using System;
//using System.Linq;
using System.Collections.Generic;
using System.Collections;
//
using OtherFunctions;

string GetUserInput(string msg = "Enter a value: ")
{
    // get a line from the user
    msg.Pp(Console.Write);
    string line = "";
    line = Console.ReadLine();
    // check the line is not empty
    while (string.IsNullOrEmpty(line))
    {
        // tell the user they have to enter something
        $"{line} - Invalid Input. Input must NOT be empty.".Pp();
        // get another line from the user
        msg.Pp(Console.Write);
        line = Console.ReadLine();
    }

    return line.Trim();
}

var line = GetUserInput();
// compare the first and the last letter of a word
FirstAndLastLetterChecker(line.First(), line.Last()).Pp();

bool FirstAndLastLetterChecker<T>(T first, T second) where T : IComparable<T>
{
    return first.CompareTo(second) == 0;
}



namespace OtherFunctions
{
    static class Printer
    {
        public static void Pp(this object obj, Action<object> p = null)
        {
            p ??= Console.WriteLine;
            p(obj);
        }
    }

    static class StrUtil
    {
        public static string First(this string obj)
        {
            if (obj.Length == 0)
            {
                throw new Exception("Can't be empty.");
            }
            return obj.Substring(0, 1);
        }

        public static string Last(this string obj)
        {
            var result = "";
            if (obj.Length == 0)
            {
                throw new Exception("Can't be empty.");
            }
            else if (obj.Length == 1)
            {
                result = obj.Substring(0, 1);
            }
            else
            {
                result = obj.Substring(obj.Length - 1);
            }
            return result;
        }
    }
}
