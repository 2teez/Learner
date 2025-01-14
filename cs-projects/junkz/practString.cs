using System;
using System.Linq;
using System.Text;
using StringExt;

namespace StringPracticeTest
{
    class StringPractice
    {

        static void Main(string[] args)
        {
            var say = "Hello, now or never...";
            Console.WriteLine(say.Reverser());
        }
    }
}

namespace StringExt
{
    public static class StringExtention
    {
        public static string Reverser(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var value in str.Reverse())
            {
                sb.Append(value);
            }
            return sb.ToString();
        }
    }
}
