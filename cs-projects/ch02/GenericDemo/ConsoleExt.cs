using System.IO;

namespace SystemExt
{
    static class SystemExtension
    {
        public static void Print<T>(this System.IO.TextWriter t, params T[] data)
        {
            foreach (var d in data)
            {
                t.WriteLine(d);
            }
        }
        public static void PrintLine<T>(this System.IO.TextWriter t, params T[] data)
        {
            foreach (var d in data)
            {
                t.WriteLine(d);
            }
        }
    }
}
