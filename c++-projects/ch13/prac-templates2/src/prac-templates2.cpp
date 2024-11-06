
#include <cstddef>
#include <iostream>
#include <array>
// checking the class template
template <typename T, std::size_t S>
std::ostream& pretty_print(std::ostream&, const std::array<T, S>);

int main(int argc, char** argv) {

    std::array<int, 10> arr {1,5,7,8,3,8,5,4};
    pretty_print(std::cout, arr);
    return 0;
}

template <typename T, std::size_t S>
std::ostream& pretty_print(std::ostream& os, const std::array<T, S> arr) {
    os << '[';
    std::size_t i = 0;
    for (; S-1 > i; ++i) {
        os << arr[i] << ',';
    }
    os << arr[i];
    os << ']';
    return os;
}
