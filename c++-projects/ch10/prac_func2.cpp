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

typedef bool (*func)(size_t);

bool is_prime(size_t);
void prime_teller(size_t, bool=1);

int main(int argc, char** argv) {
    int nums[] {3,7,23,17,6};
    for (auto num: nums) {
        //std::cout << is_prime(num);
        prime_teller(num, is_prime(num));
    }
    return 0;
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
