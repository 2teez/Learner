
#include <string>
#include <iostream>
#include "prac_template.h"
#include "prac_template.cpp"

int main(int argc, char** argv) {

    Pair<std::string, int> pair {"kye", 21};
    std::cout << pair.get_value_at0() << std::endl;

    auto sam = Pair<std::string, int>::with("sam", 23);
    std::cout << *(static_cast<int*>(sam.get_value_at(1))) << std::endl;
    std::cout << pair << std::endl;
    return 0;
}
