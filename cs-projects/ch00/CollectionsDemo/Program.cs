using System.Collections;

class CollectionsTest
{
    public static void Main(string[] args)
    {
        var names = new ArrayList();
        Console.WriteLine(names);
        // get names of various persons or langauges
        // then print those
        var line = "";
        while ((line = getString("Values: ")) != "exit")
        {
            names.Add(line);
        }
        PrintArrayList(names);
    }

    static string getString(string msg = "Enter a value: ")
    {
        if (msg == "Enter a value: ")
        {
            Console.Write(msg.Substring(0, msg.Length - 2) + ". 'exit' to finish: ");
        }
        else
        {
            Console.Write(msg.Substring(0, msg.Length - 2) + ". 'exit' to finish: ");
        }

        var line = "";
        do
        {
            line = Console.ReadLine();
        } while (line == "");
        return line;
    }

    static void PrintArrayList(ArrayList list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}
