
#include <iostream>
#include <fstream>
#include <string>
#include <cstring>

std::istream& read(std::istream& f);

int main(int argc, char* argv[]) {


    std::string filename{};

    std::cout << "Enter a filename: ";
    read(std::cin) >> filename;

    std::fstream filereader(filename.c_str(), std::ios::in);
    if (filereader.fail()) {
        std::cout << "File: " + filename + " doesn't exist.";
        std::exit(-1);
    }

    std::string wrd;
    while(read(filereader) >> wrd)
        std::cout << wrd;

    filereader.close();

    while(read(std::cin) >> wrd)
        std::cout << wrd;

    return 0;
}

std::istream& read(std::istream& f) {
    return f;
}

