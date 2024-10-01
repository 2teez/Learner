#include "prac_cl.h"
#include <iostream>

Calculator::Calculator(const operation::Operation& op): op(op){}

int Calculator::calculate(int a, int b) {
    int result {};
    switch(op) {
        case operation::Operation::Add:
            result = a + b;
            break;
        case operation::Operation::Subtract:
            result = a - b;
            break;
        case operation::Operation::Multiply:
            result = a * b;
            break;
        case operation::Operation::Divide:
            if (b != 0)
                result = a + b;
            else {
                std::cout << "Can't divide by Zero!";
            }
            break;
        default:
            ;
    }
    return result;
}
