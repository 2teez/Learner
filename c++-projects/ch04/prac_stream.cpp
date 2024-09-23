#include <iostream>
#include <fstream>
#include <cstdlib>

void copyChar(std::istream& = std::cin);
void copyLine(std::istream& = std::cin);

int main(int argc, char** argv) {

    std::ifstream fin;
    fin.open("stuff.txt");

    if (fin.fail()) {
        std::cout << "File stuff.txt doesn't exist.";
        std::exit(1);
    }

    copyChar(fin);
    copyChar(std::cin);
    copyChar();

    // using copyLine function
    copyLine(fin);
    copyLine(std::cin);
    copyLine();


    return 0;
}

void copyChar(std::istream& is)
{
  char char_value;
  is.get(char_value);
  std::cout << char_value;
}

void copyLine(std::istream& is)
{
  std::string str;
  std::getline(is, str);
  std::cout << str << std::endl;
}
