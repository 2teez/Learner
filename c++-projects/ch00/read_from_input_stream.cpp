
#include <iostream>
//#include "../str_util.h"

int main(int argc, char** argv)
{
    int value(0),
        sum(0);

    while(std::cin >> value)
    {
        sum += value;
    }

    //std::cout << MyString::operator<<(std::cout, std::to_string(sum)) << std::endl;
    std::cout << sum << std::endl;

    return 0;
}
