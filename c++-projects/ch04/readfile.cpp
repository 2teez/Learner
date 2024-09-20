#include <iostream>
#include <fstream>
#include <string>
int main(int argc, char** argv) {



std::ofstream input;
std::string filename(get_value("Enter filename "));

input = std::fopen(filename, "w");
while(!input.eof()) {
    std::cout << input.line;
}

std::string get_value(const std::string& msg) {
    std::cout << msg << ": ";
    std::string str;
    std::getline(std::cin, str);

    return str;
}
return 0;
}