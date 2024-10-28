#include <iostream>
#include <memory>
#include <initializer_list>

template <typename R=char, typename T>
void print(const std::initializer_list<T> = {}, const R='\n');

template <typename R=char, typename T>
void print(const T, const R='\n');

//void do_something(std::auto_ptr<int> data) {
void do_something(std::shared_ptr<int> data) {
    *data = 11;
}

int main(int argc, char** argv) {
    std::shared_ptr<int> mytest{new int{10}};
    do_something(mytest);
    std::cout << *mytest << "\n";
    *mytest = 13;
    std::cout << *mytest << "\n";

    // checking some auto initialization
    auto age {34};
    print(age);
    print<std::string>(age, "::");
    return 0;
}

template <typename R, typename T>
void print(const std::initializer_list<T> values, const R sep) {
    for (const auto& value : values) {
        std::cout << value << sep;
    }
}

template <typename R, typename T>
void print(const T value, const R sep) {
    const auto values = {value};
    print(values, sep);
}
