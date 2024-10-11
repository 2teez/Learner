
#include <iostream>
#include <cstddef>

int main(int argc, char** argv) {

    std::unique_ptr<double> pdata {std::make_unique<double>(89.23)};
    std::cout << pdata << "::" << *pdata << "::" << pdata.get() << std::endl;
    *pdata = 34.97;
    std::cout << *pdata << std::endl;

    return 0;
}
