
#include <cstddef>
#include <iostream>
#include <array>
#include <ostream>
// checking the class template
template <typename T, std::size_t S>
std::ostream& pretty_print(std::ostream&, const std::array<T, S>);

template <std::size_t S>
std::ostream& pretty_print(std::ostream&, const std::array<char, S>);

int main(int argc, char** argv) {

    std::array<int, 10> arr {1,5,7,8,3,8,5,4};
    pretty_print(std::cout, arr);
    std::cout << '\n';
    std::array<char, 10> arr_str {"clojure"};
     pretty_print(std::cout, arr_str);

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

template <std::size_t S>
std::ostream& pretty_print(std::ostream& os,
    const std::array<char, S> arr) {
        os << '[';
        for (const auto& ch: arr)
        os << ch;
        os << ']';
       return os;
    }
