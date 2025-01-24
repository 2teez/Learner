using System;
using Util;

namespace PracticeUnsafeCs
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 31;
            a.Pp("a Before the unsafe swap..");
            b.Pp("b Before the unsafe swap..");
            unsafe
            {
                Swap(&a, &b);
            }
            a.Pp("a After the unsafe swap..");
            b.Pp("b After the unsafe swap..");
        }
        public static unsafe void Swap(int* a, int* b)
        {
            int temp = *a;
            *a = *b;
            *b = temp;
        }
    }
}

namespace Util
{
    static class Print
    {
        public static void Pp(this object obj, string msg = "Value:")
        {
            Console.WriteLine(msg);
            Console.WriteLine(obj);
        }
    }
}
