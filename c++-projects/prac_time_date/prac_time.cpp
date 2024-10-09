
#include <iostream>
#include <ctime>

int main(int argc, char** argv) {
    std::time_t current_time = std::time(nullptr);
    std::tm* localtime = std::localtime(&current_time);
    std::cout << "Current time is: " << std::asctime(localtime) << std::endl;

    return 0;
}
