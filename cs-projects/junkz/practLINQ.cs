using System;
using System.Linq;
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
