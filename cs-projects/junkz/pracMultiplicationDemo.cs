using System;
using Utils;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            TimesTable(1, 12, 1, 13, Orientation.Horizontal);
            //TimesTable(1, 25);
        }

        public static void TimesTable(int _from, int _to, int start = 1, int stop = 12,
            Orientation o = Orientation.Vertical)
        {
            if (o == Orientation.Vertical)
            {
                for (var i = _from; i < _to; ++i)
                {
                    for (var j = start; j < stop; ++j)
                    {
                        i.Times(j).Pp();
                    }
                }
            }
            else
            {
                for (var j = start; j < stop; ++j)
                {
                    for (var i = _from; i < _to; ++i)
                    {
                        i.Times(j).PadRight(15).Pp(Console.Write);
                    }
                    "".Pp();
                }
            }
        }
    }

    enum Orientation
    {
        Vertical,
        Horizontal,
    }
}


namespace Utils
{
    static class Printer
    {
        public static void Pp(this object obj, Action<object> p = null)
        {
            p ??= Console.WriteLine;
            p(obj);
        }
    }

    static class Multiplcation
    {
        public static string Times(this int number, int otherNumber)
        {
            return $"{number} x {otherNumber} = {number * otherNumber}";
        }
    }
}
