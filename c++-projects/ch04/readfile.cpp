#include <iostream>
#include <fstream>
#include <string>
#include <cstring>

std::string get_value(const std::string&);

int main(int argc, char** argv) {

    std::ifstream input;
    std::string filename = get_value("Enter filename ");

    input.open(filename.c_str());
    while(!input.eof()) {
        std::cout << input;
    }
    input.close();

    return 0;
}

std::string get_value(const std::string& msg) {
    std::cout << msg << ": ";
    std::string str;
    std::getline(std::cin, str);

    return str;
}
