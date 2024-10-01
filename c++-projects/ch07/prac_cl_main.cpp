#include <iostream>
#include "prac_cl.h"

int main(int argc, const char** argv) {
    Calculator add(operation::Operation::Add);
    std::cout << add.calculate(4, 73) << std::endl;

    std::cout << Calculator{operation::Operation::Divide}.calculate(5, 0)
    <<std::endl;

    return 0;
}
