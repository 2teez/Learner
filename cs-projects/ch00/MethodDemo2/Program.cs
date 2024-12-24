using System;

class MethodDemo2
{
    static void Main(string[] args)
    {
        int number = 20;
        Console.WriteLine("value number: " + number);
        add(number);
        Console.WriteLine("value number: " + number);
        addRef(ref number);
        Console.WriteLine("value number: " + number);
        string name;
        int age;
        readPerson(out name, out age);
        Console.WriteLine(name + '-' + age);

        int[] arr = new int[10];
        for (int i = 0; i < 10; i++) {
            arr[i] = readInt(prompt:"Enter number "+ (i+1) +": ", low:0, high:10);
        }
    }
    static void add(int i)
    {
        i += 1;
        Console.WriteLine("value i in the method: " + i);
    }
    static void addRef(ref int i)
    {
        i += 1;
        Console.WriteLine("value i in the method: " + i);
    }

    static void readPerson(out string name, out int age)
    {
        name = readString("Get a name: ");
        age = readInt(0, 100, "what is your age: ");
    }
    static string readString(string prompt)
    {
        string result;
        do {
            Console.Write(prompt);
            result = Console.ReadLine();
        }while(result == "");
        return result;
    }

    static int readInt(int low, int high, string prompt="")
    {
        int result;
        do {
            result = int.Parse(readString(prompt));
        }while(result < low || result > high);
        return result;
    }
}
