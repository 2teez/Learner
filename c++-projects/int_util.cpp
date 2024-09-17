
#include "int_util.h"
#include <iostream>

namespace Integer
{
    void swap(int& first_number, int& second_number)
    {
        if (second_number < first_number)
        {
            int tmp = first_number;
            first_number = second_number ;
            second_number  = tmp;
        }
    }

    std::vector<int> get_number_range(int start, int stop)
    {
        if (stop < start)
        {
            swap(start, stop);
        }

        std::vector<int> range{};

        for(size_t num = start; num <= stop; num++)
        {
            range.push_back(num);
        }

        return range;
    }

    int get_number(const std::string& str)
    {
        std::cout << str << ": ";
        int number(0);
        std::cin >> number;
        return number;
    }
}
