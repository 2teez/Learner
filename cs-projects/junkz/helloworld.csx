
System.Console.WriteLine("Hello, World!");
readFile(readString("Enter a filename: "));

void readFile(string filename) {
    System.IO.StreamReader reader = new System.IO.StreamReader(filename);
    while(reader.EndOfStream == false) {
       System.Console.WriteLine(reader.ReadLine());
    }
    reader.Close();
}

string readString(string prompt="") {
    string result="";
    do {
       System.Console.Write(prompt);
       result = System.Console.ReadLine();
    }while(result == "");
    return result;
}
