#include <cstddef>
#include <ios>
#include <iostream>
#include <array>
#include <iomanip>
#include <sstream>
#include <string>

inline std::string str_repeat(const std::string& str, size_t n) {
    std::ostringstream os {};
    for (size_t i = 0; i < n; ++i) os << str;
    return os.str();
}

int main(int argc, char* argv[]) {

    std::cout << "Enter the array size: ";
    int array_size {};
    std::cin >> array_size;
    double* narr = new double[array_size];

    for (int i {}; i < array_size; ++i) {
        *(narr+i) = 1 / std::pow((i+1), 2.0);
    }

    std::cout << std::fixed;
    std::cout << std::setprecision(4);
    double sum {};
    std::cout << "Value" << std::setw(8) << "Sum" << std::setw(6)
    << "X 6" << std::setw(8) << "Sqrt All" << std::endl;
    std::cout << str_repeat("=", 35)<< std::endl;
    for (int i {}; i < array_size; ++i) {
        sum += *(narr+i);
        std::cout << *(narr+i) << std::setw(8) << sum << std::setw(8)
        << sum * 6 << std::setw(8) << std::sqrt(sum * 6) << std::endl;
    }

    delete [] narr;
    return 0;
}
