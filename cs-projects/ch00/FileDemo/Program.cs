using System;
using System.IO;

class FileDemo
{
    static void Main(string[] args)
    {
        ReadFile(ReadString(prompt: "Enter filename: "));
    }

    static string ReadString(string prompt = "")
    {
        string result = "";
        do
        {
            Console.Write(prompt);
            result = Console.ReadLine();
        } while (result == "");
        return result;
    }

    static void ReadFile(string filename)
    {
        StreamReader reader = new StreamReader(filename);
        while (!reader.EndOfStream)
        {
            Console.WriteLine(reader.ReadLine());
        }
        reader.Close();
    }
}
