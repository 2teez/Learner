
#include <iostream>
#include "money.h"

int main(int argc, char** argv)
{
    Money m1 = Money(3, 5);
    auto m2 = Money(5, 89);
    std::cout << m1 << m2 << std::endl;

    std::cout << (m1 == m2) << "\n";
    std::cout << m1 + m2 << "\n";
    std::cout << m1 - m2 << "\n";
    return 0;
}
