#include "abs.h"

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

    /*template <typename T>
    T abs(T& value) {
        if (value < 0) {
            return static_cast<T>(-1)*(value);
        }
        return value;
        }*/
}
