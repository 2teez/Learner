using Stacks;
using StringUtil;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stacks.Stack<string> stack = new Stacks.Stack<string>(5);
            stack.Print();
            stack.Push("rust");
            stack.Push("c#");
            stack.Print();
            stack.Peek();
            stack.Pop();
            //stack.Print();
            //Console.WriteLine(stack.Size);
            stack.Push("zig-lang");
            stack.Push("odin");
            stack.Push("ocaml");
            stack.Print();
            stack.Peek();
            stack.Pop();
            stack.Pop();
            stack.Pop().Print("Popped Value: ");
            stack.Print();
            stack.Pop();
            stack.Print();
            stack.Push("javascript");
            stack.Push("php");
            stack.Print();
        }
    }
}

namespace StringUtil
{
    static class StringUtil
    {
        public static void Print(this string str, string msg = "")
        {
            if (!string.IsNullOrEmpty(msg))
            {
                Console.WriteLine($"{msg}");
            }
            Console.WriteLine($"{str.PadLeft(str.Length * 3)}");
        }
    }
}
