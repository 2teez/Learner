#include <iostream>
#include <stdexcept>
#include "calculator.h"

int main(int argc, char** argv) {
    Calculator val1(4), val2(5);
    std::cout << val1 + val2 << std::endl;

    Calculator v3 (0);
    try {
        std::cout << val1/v3 << std::endl;
    } catch(std::runtime_error re) {
        std::cout << re.what() << std::endl;
    }

    return 0;
}
