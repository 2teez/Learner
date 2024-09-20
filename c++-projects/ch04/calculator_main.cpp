#include <iostream>
#include "calculator.h"

int main(int argc, char** argv) {
    Calculator val1(4), val2(5);
    std::cout << val1 + val2 << std::endl;

    return 0;
}
