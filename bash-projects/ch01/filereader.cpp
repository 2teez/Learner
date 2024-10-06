#include <iostream>
#include <fstream>
#include <string>
#include <cstring>

int main(int argc, char** argv) {

    std::string filename {};

    if (argc != 2) {
        std::cout << "Enter filename: ";
	std::getline(std::cin, filename);
    } 

    // file stream open
    std::fstream file(filename.c_str(), std::ios::in);
    // test if the file opening fails
    if (file.fail()) {
	std::cout << "Fail doesn't exist.";
	std::exit(-1);
     }
    // read the file if it exist
    while(!file.eof()) {
	    std::cout << file;
    }
    file.close();

    return 0;
}
