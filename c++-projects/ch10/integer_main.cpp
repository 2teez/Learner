
#include <iostream>
#include <cstddef>
#include "integer.h"

int main(int argc, char** argv) {

    Integer num {1};
    std::cout << num << num.get_value() + 3 << '\n';
    std::cout << Integer {34};
    num.set_value(65);
    std::cout << num;

    const Integer cnum {3};
    std::cout << cnum;

    Integer dnum {};
    std::cout << dnum;

    Integer ccon {dnum};
    ccon.set_value(21);
    std::cout << dnum << ccon;

    std::cout << ccon.compare(num);
    return 0;
}
