using System;

class ArrayDemo 
{
    static void Main(string[] args) 
    {
        int[] arr = new int[10];
	for (int i = 0; i < 10; i++) {
	    arr[i] = readInt(prompt: "Enter number 1 to 10 [" + (i+1) + "]: ", low:1, high:10);
	}
	// display the array
	for (int i = 0; i < 10; i++)
	    Console.WriteLine(arr[i]);
    }

    static string readString(string prompt="") 
    {
	string result="";
        do
	{
	    Console.Write(prompt);
            result = Console.ReadLine();
	}while(result=="");
	return result;
    }

    static int readInt(int low, int high, string prompt="", string errMsg="Invalid Input")
    {
        int result = int.Parse(readString(prompt));
	while(result < low || result > high) 
	{
	    Console.WriteLine(errMsg);
	    result = int.Parse(readString(prompt));
	}
    	return result;
    }
}
