#include <iostream>
#include <stddef.h>

int main(int argc, char** argv)
{
    std::cout << "Enter two numbers: ";
    int num1 = {0}, num2 = {0};  // numbers variables
    std::cin >> num1 >> num2;
    // summation
    std::cout << "Sum of " << num1 << " and " << num2 << " = " <<
    num1 + num2 << std::endl;
    // multiplication of two numbers
    std::cout << "The Product of " << num1
    << " and " << num2 << " = " << num1 * num2 << std::endl;
    return 0;
}
