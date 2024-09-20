#include <iostream>
#include <stdexcept>
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


double Calculator::operator-(const Calculator& rhs) {
    value -= rhs.value;
    return value;
}
double Calculator::operator*(const Calculator& rhs) {
    value *= rhs.value;
    return value;
}
double Calculator::operator/(const Calculator& rhs) {
    if (rhs.value == 0) {
        throw std::runtime_error("Can't divide by Zero.");
    }
    value /= rhs.value;
    return value;
}
