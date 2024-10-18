/*
exercise 8-5. Define a function that checks whether a given number is prime. Your
primal check does not have to be efficient; any algorithm you can think of will do. In
case you have forgotten, a prime number is a natural number strictly greater than
1 and with no positive divisors other than 1 and itself. Write another function that
generates a vector<> with all natural numbers less or equal to a first number and
starting from another. By default it should start from 1. Create a third function that
given a vector<> of numbers outputs another vector<> containing all the prime
numbers it found in its input. Use these three functions to create a program that prints
out all prime numbers less or equal to a number chosen by the user (print, for instance,
15 primes per line). Note: In principle, you do not need any vectors to print these prime
numbers; obviously, these extra functions have been added for the sake of the exercise.
*/
#include <iostream>
#include <cstddef>
#include <string_view>
#include <vector>
#include <iomanip>

typedef bool (*func)(size_t);

bool is_prime(size_t);
void prime_teller(size_t, bool=1);
std::vector<int> generate_prime_nums(size_t=1,size_t=16);
void print_it(const std::vector<int>&, const std::string_view& =" ");

int main(int argc, char** argv) {
    /*int nums[] {3,7,23,17,6};
    for (auto num: nums) {
        //std::cout << is_prime(num);
        prime_teller(num, is_prime(num));
        }*/
    std::cout << "Enter a number of choice: ";
    unsigned number {};
    std::cin >> number;
    print_it(generate_prime_nums(number));
    return 0;
}

void print_it(const std::vector<int>& numbers, const std::string_view& ch) {
    for (size_t i {}; i < numbers.size(); ++i) {
        if (0 == i%15) std::cout << std::endl;
        std::cout << std::right << std::setw(3) << numbers.at(i) << ch;
    }
    std::cout << std::endl;
}

std::vector<int> generate_prime_nums(size_t start, size_t stop) {
    std::vector<int> numbers{};
    if (start == 1) { start += 1;}
    else if (start > stop) {
        std::swap(start, stop);
        start = 2;
    }
    int counter {};
    do {
        if (is_prime(start)) {
            numbers.push_back(start);
            ++counter;
        }
        ++start;
    } while(counter < stop);
    return numbers;
}

void prime_teller(size_t num, bool b) {
    if (b) {std::cout << num << " is a prime number. \n";}
    else
    std::cout << num << " is NOT a prime number. \n";
}

bool is_prime(size_t num) {
    for (size_t i = 2; i < num/2; ++i) {
        if (0 == num % i) {
            return false;
        }
    }
    return true;
}
