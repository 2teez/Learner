#include <iostream>
#include <ctime>

int main(int argc, char** argv) {
    std::time_t timer = std::time(nullptr);

    std::cout << std::ctime(&timer) << std::endl;

    std::tm* lt = std::localtime(&timer);
    std::cout << 1900+lt->tm_year << std::endl;

    return 0;
}
