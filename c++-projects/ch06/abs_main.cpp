#include <iostream>
#include "abs.h"

namespace Sorter {
    template <typename T>
    void sort(T[], size_t);
}

namespace Swapper {
    template <typename T>
    void swap(T&, T&);
}

template <typename T>
void printer(T[], size_t);

int main(int argc, char** argv) {

    std::cout << Absolute::maximum(5, 9) << std::endl;
    std::cout << Absolute::abs(-59) << std::endl;

    int arr[] = {4,7,0,6,8,3,1,2};
    auto size = sizeof(arr)/sizeof(arr[0]);
    printer(arr, size);
    Sorter::sort(arr, size);
    printer(arr, size);

    std::string names[] = {"kunle", "adigun", "horse", "muphy"};
    printer(names, 4);
    Sorter::sort(names, 4);
    printer(names, 4);

    // sorting double values
    double b[5] = {5.5, 4.4, 1.1, 3.3, 2.2};
    std::cout << "Before Sorting...\n";
    printer(b, sizeof(b)/sizeof(b[0]));
    Sorter::sort(b, 5);
    std::cout << "After Sorting...\n";
    printer(b, sizeof(b)/sizeof(b[0]));

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

namespace Sorter {
    template <typename T>
    void sort(T arr[], size_t size) {
        for(size_t i = 0; i < size; ++i) {
            for (size_t j = 0; j < size; ++j) {
                if (arr[i] < arr[j]) {
                    Swapper::swap(arr[i], arr[j]);
                }
            }
        }
    }
}

namespace Swapper {
    template <typename T>
    void swap(T& lhs, T& rhs) {
        T temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}

template <typename T>
void printer(T arr[], size_t size) {
    for (auto i = 0; i < size; ++i) {
        std::cout << arr[i] << ", ";
    }
    std::cout << std::endl;
}
