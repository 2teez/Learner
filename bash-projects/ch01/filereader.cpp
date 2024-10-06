#include <iostream>
#include <fstream>
#include <string>
#include <cstring>

std::fstream get_file(const std::string&);
std::string named(const char*);

int main(int argc, char** argv) {

    std::string filename {};

    if (argc != 2) {
        filename = named("Enter a filename: ");
    } else filename = std::string{argv[1]};

    // file stream open using get_file function
     std::fstream file = get_file(filename);
     std::string line {};
    // read the file if it exist
    while(!file.eof()) {
	    std::getline(file, line);
		std::cout << line << std::endl;
    }
    file.close();

    return 0;
}

std::string named(const char* msg) {
    std::cout << msg;
    std::string filename {};
    std::getline(std::cin, filename);
    return filename;
}

std::fstream get_file(const std::string& filename) {
    std::fstream file(filename.c_str(), std::ios::in);
    // test if the file opening fails
    while (file.fail()) {
        std::cout << "Fail doesn't exist.\n";
        //std::exit(-1);
        file = get_file(named("Enter a valid filename: "));
     }

     return file;
}
