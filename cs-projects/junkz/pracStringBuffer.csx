using System.Text;
var buffer = new StringBuilder();

var line = GetString();
while(line.Trim() != "exit")
{
  buffer.Append(line);
  line = GetString("Enter Text or exit to finish: ");
}

Console.WriteLine(buffer.ToString());

string GetString(string prompt="Enter text: ")
{
    var result = "";
    do {
        Console.Write(prompt);
	result = Console.ReadLine();
    }while(result == "");
    return result;
}