
#include <iostream>
#include <algorithm>
#include "finder.h"
#include "finder.cpp"

inline bool even_count(int value) {
    return value % 2 == 0 ? true: false;
}

inline bool odd_count(int value) {
    return value % 2 == 1 ? true: false;
}

int main(int argc, char** argv) {
    int arr[] {1,2,5,7,9,4,3,21,8};
    auto even_number {counter_if(std::begin(arr), std::end(arr), even_count)};
    auto odd_number {counter_if(std::begin(arr), std::end(arr), odd_count)};
    std::cout << even_number << " :: " << odd_number << "\n";

    std::cout << std::count_if(std::begin(arr), std::end(arr),
        [](auto const value){return value%2 == 0;}) << "\n";

    return 0;
}
