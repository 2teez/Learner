#include <iostream>
#include <cstdlib>
#include <fstream>

int main(int argc, char** argv)
{
    std::fstream input("sample.txt", std::ios::in);
    if (input.fail()) {
        std::cout << "File: sample.txt doesn't exist";
        std::exit(1);
    }
    char ch;
    std::cout << "<PRE>\n";
    while(input.get(ch)) {
        if (ch == '<') {
            std::cout << "&lt;";
        } else if (ch == '>') {
            std::cout << "&gt;";
        } else {
            std::cout << ch;
        }
    }
    std::cout << "</PRE>\n";
    std::cout << std::endl;
    return 0;
}
