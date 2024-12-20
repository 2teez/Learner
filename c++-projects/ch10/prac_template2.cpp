/*
exercise 9-3. Write a function template plus() that takes two arguments of potentially
different types and returns a value equal to the sum of both arguments. Next, make
sure that plus() can be used as well to add the values pointed to by two given
pointers.
extra: Can you now make it so that you can also concatenate two string literals using
plus()? Warning: This may not be as easy as you think!
*/
#include <iostream>
#include <algorithm>

template <typename T1, typename T2>
auto plus(T1 a, T2 b) -> decltype(a+b) {
    return a + b;
}

/*template <>
auto plus(int* a, double* b) -> decltype(*a + *b){
    return *a + *b;
    }*/

int main(int argc, char** argv) {
    std::cout << plus(34, 1.25) << '\n';
    std::cout << plus(std::string {"omit"}, "ida") << '\n';
    /*int x = 4;
    int y = 6;
    std::cout << plus(&x, &y) << "\n";*/
    return 0;
}
