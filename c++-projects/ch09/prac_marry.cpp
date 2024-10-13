#include <iostream>
#include <array>
#include <iomanip>

int main(int argc, char* argv[]) {

    std::array<int, 50> arr {0};
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
    return 0;
}
