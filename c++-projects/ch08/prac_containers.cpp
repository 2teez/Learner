
#include <variant>
#include <array>
#include <iostream>
#include <cstdbool>
#include <vector>

/*
Write a function that takes a pair of iterators to a
vector<int> and an int value. Look for that value in the range
and return a bool indicating whether it was found.
*/
template <typename T>
bool checker(std::vector<int>::const_iterator,
    std::vector<int>::const_iterator, T);

template <typename T>
std::variant<std::vector<int>::const_iterator, bool> checks(std::vector<int>::const_iterator,
    std::vector<int>::const_iterator, T);

int main(int argc, char** argv) {
    std::vector<int> int_values {6, 8, 23, 9, 5, 1};
    std::array<std::string, 2> status {"false", "true"};
    std::cout << status[checker(int_values.cbegin(), int_values.cend(), 5)] << "\n";
    std::cout << status[checker(int_values.cbegin(), int_values.cend(), -45)] << "\n";
    //std::cout << *checks(int_values.cbegin(), int_values.cend(), -45) << "\n";
    return 0;
}

template <typename T>
bool checker(std::vector<int>::const_iterator beg,
    std::vector<int>::const_iterator end, T item) {

        while(beg != end) {
            if (*beg == item) return true;
            ++beg;
        }
    return false;
}

template <typename T>
std::variant<std::vector<int>::const_iterator, bool> checks(std::vector<int>::const_iterator beg,
    std::vector<int>::const_iterator end, T item) {

        while(beg != end) {
            if (*beg == item) return beg;
            ++beg;
        }
    return false;
}
