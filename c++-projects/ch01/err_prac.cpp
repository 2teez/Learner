#include <iostream>
#include <stdexcept>

template <typename T>
T get_value(const char*);

int main(int argc, char** argv)
{
    while (true)
    {
        auto num1 = get_value<int>("Enter the first value: "),
            num2 = get_value<int>("Enter the second value: ");

        if (num2 == 0)
        {
            throw std::invalid_argument("Second number can't be zero.");
        }
        auto value(0);
        try
        {
            value = num1 / num2;
        }
        catch (std::invalid_argument err)
        {
            std::cout << err.what() << std::endl;
        }

        std::cout << num1 << " divided by " << num2 << " is " << value << std::endl;
        }

        return 0;
}

template <typename T>
T get_value(const char* msg)
{
    std::cout << msg;
    T value;
    std::cin >> value;
    return value;
}
