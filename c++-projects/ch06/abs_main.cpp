#include <iostream>
#include "abs.h"

int main(int argc, char** argv) {

    std::cout << Absolute::maximum(5, 9) << std::endl;
    std::cout << Absolute::abs(-59) << std::endl;

    return 0;
}

namespace Absolute {
    template <typename T>
    T maximum(T lhs, T rhs) {
        T max;
        if (lhs > rhs) {
            max = lhs;
        } else {
            max = rhs;
        }
        return max;
    }

    template <typename T>
    T abs(T value) {
        if (value < 0) {
            return static_cast<T>(-1)*(value);
        }
        return value;
        }
}
