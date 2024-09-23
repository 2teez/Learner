#include <iostream>
#include <fstream>
#include <cstdlib>

void copyChar(std::istream& = std::cin);
void copyLine(std::istream& = std::cin);
void sendLine(std::ostream& = std::cout);

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

    // close fin file
    fin.close();

    // using sendLine
    std::ofstream fout;
    fout.open("morestuf.txt");

    if (fout.fail()) {
        std::cout << "File morestuff.txt doesn't exist.";
        std::exit(1);
    }

    std::cout << "Enter 2 lines of input:\n";
    sendLine(fout);
    sendLine(std::cout);
    sendLine(); // call std::cout implicitly
    fout.close();

    return 0;
}

void copyChar(std::istream& is)
{
  char char_value;
  is.get(char_value);
  std::cout << char_value << std::endl;
}

void copyLine(std::istream& is)
{
  std::string str;
  std::getline(is, str);
  std::cout << str << std::endl;
}

void sendLine(std::ostream& os)
{
  std::string str;
  std::getline(std::cin, str);
  os << str << std::endl;
}
