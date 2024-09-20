#include <iostream>
#include <ctime>

int main(int argc, char** argv) {
    std::time_t timer = std::time(nullptr);

    std::cout << std::ctime(&timer) << std::endl;
    return 0;
}
