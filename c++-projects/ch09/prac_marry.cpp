#include <iostream>
#include <array>
#include <iomanip>

int main(int argc, char* argv[]) {

    int arr[50]{0}; // used std::array<int, 50> {}; // initially
    int odd_numbers {1};

    // fill array with the first 50 odd numbers
    auto counter {0};
    while (true) {
        if (counter == 50) break;
        arr[counter] = (odd_numbers+=2);
        ++counter;
    }

    counter = 0; // reset
    for (const auto num: arr) {
        if (counter == 10) {
            std::cout << std::endl;
            counter = 0; // reset
        }
        if (num < 100) {
            std::cout << std::setw(2) << num << " ";
        } else {
            std::cout << num << " ";
        }
        ++counter;
    }
    std::cout << std::endl;

    // display array numbers using pointer arithmetics
    counter = 0; // reset
    for (int i {}; i < std::size(arr); ++i) {
        if (counter == 10) {
            std::cout << std::endl;
            counter = 0; // reset
        }
        if (i < 100) {
            std::cout << std::setw(2) << *(arr+i) << " ";
        } else {
            std::cout << *(arr+i) << " ";
        }
        ++counter;
    }
    std::cout << std::endl;
    // print in reverse
    counter = 0; // reset
    for(auto i = std::end(arr)-1; i >= std::begin(arr); --i) {
        if (counter == 10) {
            std::cout << std::endl;
            counter = 0; // reset
        }
        if (*i < 100) {
            std::cout << std::setw(2) << *i << " ";
        } else {
            std::cout << *i << " ";
        }
        ++counter;
    }
    std::cout << "\n";

    return 0;
}
