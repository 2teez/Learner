#include <iostream>
#include <string>

int main(int argc, char** argv)
{
    std::string value;
    while (getline(std::cin, value))
    {
        std::string::size_type len = value.size();
        if (len > 6)
        {
            std::cout << value << std::endl;
        }
    }

    return 0;
}
