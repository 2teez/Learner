using System;
using System.IO;
using System.Linq;
using StringFunctionsTest;

namespace MainClass
{
    public delegate string FunctionPasser(string str);
    class MyStringTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                StringExtraFunctions.ReversePigLatin(
                    StringExtraFunctions.GetPigLatin("forever")));

            Console.Write("Enter a filename: ");
            var filepath = Console.ReadLine();
            FunctionPasser getPigLatin = StringExtraFunctions.GetPigLatin;
            ReadAFile(filepath, getPigLatin);
        }

        static void ReadAFile(string filepath, FunctionPasser fn)
        {
            StreamReader reader = new StreamReader(filepath);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                Console.WriteLine(fn(line));
            }
            reader.Close();
        }
    }
}
