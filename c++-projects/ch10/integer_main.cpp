
#include <iostream>
#include <cmath>
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

    std::cout << ccon.compare(num) << '\n';

    std::cout << ccon + num << '\n';
    std::cout << ccon << num;

    //// 4×53+6×52+7×5+8
    std::cout << Integer {4}
    * Integer {static_cast<int>(std::pow(5.0, 3))}
    + Integer {6}
    * Integer {static_cast<int>(std::pow(5.0, 2))}
    + Integer {7}
    * Integer {5}
    + Integer {8} << '\n';

    Integer::printCount();  // static method
    return 0;
}
