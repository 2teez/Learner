
#include <iostream>
#include <cstddef>
#include <iomanip>

extern double power(double, int);
extern const unsigned value;

int main(int argc, char** argv) {
    for (int i {}; i < value; ++i) {
        std::cout << std::setw(8) << power(8.0, i) << "\n";
    }
    return 0;
}
