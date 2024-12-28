using System.Collections;
using Collect;

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
        PrintArrayList(/*ref*/ names);
        // using my class person from collect module
        var collect = new ArrayList();
        collect.Add(new Customer(item: "7up", price: 1.56m));
        collect.Add(new Customer(item: "Carmel-Chocolate", price: 1.85m));
        PrintArrayList(collect);
        Console.WriteLine(((Customer)collect[0]).GetItem);

        //var item = new Customer.Item(item: "Coke", price: 2.95m);
        //Console.WriteLine(item);
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

    static void PrintArrayList(/*ref*/ ArrayList list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}
