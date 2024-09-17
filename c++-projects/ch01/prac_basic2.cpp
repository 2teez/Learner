
#include <iostream>
#include <string>

int main(int argc, char** argv)
{
    std::string value;
    while (std::cin >> value)
    {
        std::cout << value << std::endl;
    }

    return 0;
}
