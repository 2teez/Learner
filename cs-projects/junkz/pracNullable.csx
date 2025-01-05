using System;


public string GetString(string str="Enter Value: ")
{
    string? line;
    while(string.IsNullOrEmpty(line)) {
        Console.Write(str);
        line = Console.ReadLine();
    }
    return line;
}
