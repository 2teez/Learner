using System;
using System.Linq;
//using System.Linq.Dynamic.Core;
using System.Collections.Generic;

var arr = new int[5];
GetArray(ref arr, resize: true);
PrintEnumerables(arr);
// filtered array
var filtered = from elem in arr
               where elem > 4
               select elem;
PrintEnumerables(filtered);
PrintEnumerables(from elem in arr orderby elem select elem, "Sorted Values:");
PrintEnumerables(from elem in arr orderby elem descending select elem, "Sorted Values In Descending:");
PrintEnumerables(from elem in arr where elem > 4 orderby elem descending select elem,
    "Sorted Values In Descending greater than 4:");

GetArray(ref arr, resize: true, size: 50);
PrintEnumerables(from value in arr orderby value select value, "Sorted Values: ");
PrintEnumerables(from elem in arr where (0 == elem % 2) orderby elem select elem,
    "Sorted Values, Values are Even number:");

////
// had to use a full-flied project
//Linqify.Linqified("from value in arr", "orderby value", "select value");

void GetArray(ref int[] arr, bool resize = false, int size = 10)
{
    if (resize == true)
        Array.Resize(ref arr, size);
    //Console.WriteLine(arr.Length);
    var rand = new Random();
    for (var i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(arr.Length);
    }
}

void PrintEnumerables(IEnumerable<int> arr, string msg = "Values to Print:")
{
    Console.WriteLine(msg);
    foreach (var elem in arr)
    {
        Console.Write($"{elem,3}");
    }
    Console.WriteLine();
}

struct Linqify
{
    private string statement;
    private string condition;
    private string expression;
    private Linqify(string statement, string condition, string expression)
    {
        this.statement = statement;
        this.condition = condition;
        this.expression = expression;
    }

    public static IEnumerable<int> Linqified(string statement = "from value in values",
         string condition = "", string expression = "select value", string msg = "Display Values: ")
    {
        Console.WriteLine(msg);
        var obj = new Linqify(statement, condition, expression);
        var query = $"{obj.statement}{obj.condition}{obj.expression}";
        return numbers.AsQueryable().SelectMany(query);
    }
}
