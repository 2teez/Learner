#include <iostream>
#include "calculator.h"


Calculator::Calculator(double value): value(value) {}

std::ostream& operator<<(std::ostream& os, const Calculator& cal) {
    os << cal.value;
    return os;
}

double Calculator::operator+(const Calculator& rhs) {
    value += rhs.value;
    return value;
}
