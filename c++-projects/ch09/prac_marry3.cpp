#include <iostream>
#include <iomanip>
#include <string>
#include <memory>


int main(int argc, char* argv[]) {

    std::cout << "Enter the array size: ";
    int array_size {};
    std::cin >> array_size;
    std::unique_ptr<double[]> narr = std::make_unique<double[]>(array_size);

    for (int i {}; i < array_size; ++i) {
        narr[i] = 1 / std::pow((i+1), 2.0);
    }

    std::cout << std::fixed;
    std::cout << std::setprecision(4);
    double sum {};
    std::cout << "Value" << std::setw(8) << "Sum" << std::setw(6)
    << "X 6" << std::setw(8) << "Sqrt All" << std::endl;
    std::cout << std::string(30, '=') << std::endl;
    for (int i {}; i < array_size; ++i) {
        sum += narr[i];
        std::cout << narr[i] << std::setw(8) << sum << std::setw(8)
        << sum * 6 << std::setw(8) << std::sqrt(sum * 6) << std::endl;
    }

    return 0;
}
