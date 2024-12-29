
var firstNumber = Convert.ToDouble(GetString("Enter First Number: "));
var secondNumber = double.Parse(GetString("Enter Second Number: "));

Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
// Console.ReadKey();  // press any key to end the program

string GetString(string msg="Enter value: ")
{
    var line ="";
    do
    {
        Console.Write(msg);
        line = Console.ReadLine()!.Trim();
    }while(string.IsNullOrEmpty(line));
    return line;
}
