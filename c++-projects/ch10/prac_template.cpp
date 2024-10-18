
#include <iostream>
#include <cstddef>

template <typename T> T larger(T, T);

int main(int argc, char** argv) {

    std::cout << larger<int>(4, 0.45) << std::endl;
    return 0;
}

template <typename T>
T larger(T a, T b) {
    return a  > b ? a : b;
}
