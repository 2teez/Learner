namespace Util;
class Util
{
    private Util() { }
    public static string GetString(string msg = "Enter value: ")
    {
        string? line;
        do
        {
            Console.Write(msg);
            line = Console.ReadLine();
        } while (string.IsNullOrEmpty(line));
        return line;
    }
}

class UtilC
{
    public static UtilC Instance => new UtilC();
    private UtilC() { }
    public string GetString(string msg = "Enter value: ")
    {
        string? line;
        do
        {
            Console.Write(msg);
            line = Console.ReadLine();
        } while (string.IsNullOrEmpty(line));
        return line;
    }
}
