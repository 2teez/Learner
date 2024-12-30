namespace Utility;

public class Util
{
    public static Util Instance => new Util();
    private Util() { }
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
