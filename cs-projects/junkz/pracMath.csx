
var firstNumber = Convert.ToDouble(GetString("Enter First Number: "));
var secondNumber = double.Parse(GetString("Enter Second Number: "));

Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
// Console.ReadKey();  // press any key to end the program

var direction = Direction.North;
Console.WriteLine(direction);
OppositeDirection(ref direction);
Console.WriteLine(direction);

enum Direction
{
    North,
    South,
    West,
    East,
}

void OppositeDirection(ref Direction direction)
{
    switch (direction)
    {
        case Direction.North:
            direction = Direction.South;
            break;
        case Direction.South:
           direction = Direction.North;
            break;
        case Direction.West:
            direction = Direction.East;
            break;
        case Direction.East:
            direction = Direction.West;
            break;
        default:
           direction = Direction.North;
            break;
    }
}

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
