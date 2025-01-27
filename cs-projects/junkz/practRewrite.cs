using System;
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

        }
    }
}

namespace Util
{
    static class Printer
    {
        static void Pp(
            this object obj,
            System.IO.TextWriter tw = null,
            string msg = "Printing..")
        {
            tw ??= Console.WriteLine;
            tw(msg);
            tw(obj);
        }
    }
}
