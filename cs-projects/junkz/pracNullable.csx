using System;

#nullable enable

var name = GetString("Enter your name: ");
Console.WriteLine(name);

string GetString(string str = "Enter Value: ")
{
    string? line = "";
    while (string.IsNullOrEmpty(line))
    {
        Console.Write(str);
        line = Console.ReadLine();
    }
    return line;
}
