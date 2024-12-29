using System;
using System.Text;

class PracticeString
{
    static void Main(string[] args)
    {
        // reverse a string
        var line = GetString();
        Console.WriteLine(ReverseString(line));
        Console.WriteLine(ReverseWords(line));
        Console.WriteLine(QuoteWord(line));
        Console.WriteLine(QuoteWord(str: line, quote: "]["));
    }
    static string QuoteWord(string str, char separator = ' ', string quote = "\"")
    {
        var sb = new StringBuilder();
        foreach (var word in str.Split(separator))
        {
            sb.Append($"{quote}{word}{quote}");
        }
        return sb.ToString();
    }
    static string ReverseWords(string str, char separator = ' ')
    {
        var words = str.Split(separator);
        var sb = new StringBuilder(str.Length);
        foreach (var word in words)
        {
            sb.Append(ReverseString(word) + separator);
        }
        return sb.ToString();
    }
    static string ReverseString(string str)
    {
        var sb = new StringBuilder(str.Length);
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }
    static string GetString(string msg = "Enter value: ")
    {
        var line = "";
        do
        {
            Console.Write(msg);
            line = Console.ReadLine()!.Trim();
        } while (string.IsNullOrEmpty(line));
        return line;
    }
}
