
#include <iostream>
#include "../int_util.h"

int add_numbers_range(int, int, int);
int get_number(const std::string&);


int main(int argc, char** argv)
{
    int sum = {0};
    // sum number from 1 to 10
    int start_number(0);
    // while loop
    while (start_number <= 10)
    {
        sum += start_number; // add up
        start_number += 1; // next number
    }

    std::cout << "The sum of numbers from 1 to 10 = "
    << sum << std::endl;

    while(true)
    {
        int first_number = Integer::get_number("Enter first number");
        int second_number = Integer::get_number("Enter second number");
        if (first_number > second_number)
        {
            Integer::swap(first_number, second_number);
        }
        std::cout << "The Sum of range of number from " << first_number
        <<  " and " << second_number << " is "
        << add_numbers_range(first_number, second_number, 1)
        << std::endl;

        // print the values in the std::vector
        for (auto value : Integer::get_number_range(first_number, second_number))
        {
            std::cout << value << std::endl;
        }
    }

    return 0;
}

int add_numbers_range(int start, int stop, int step=1)
{
    int sum(0);
    if (stop < start)
    {
        Integer::swap(start, stop);
    }
    while(start <= stop)
    {
        sum += start;
        start += step;
    }
    return sum;
}
