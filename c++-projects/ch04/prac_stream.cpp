#include <iostream>
#include <fstream>

void copyChar(std::istream&);

int main(int argc, char** argv) {

    std::ifstream fin;
    fin.open("stuff.txt");

    copyChar(fin);
    copyChar(std::cin);

    return 0;
}

void copyChar(std::istream& is)
{
  char char_value;
  is.get(char_value);
  std::cout << char_value << std::endl;
}
