#include <iostream>
#include <initializer_list>

template <typename R=char, typename T>
void print(std::initializer_list<const T> = {}, const R='\n');

template <typename T>
void print(T...);

template <typename T=void>
inline void print(void) {
	std::cout << std::endl;
}


int main(int argc, char** argv) {

    print("Hello, World");
    print();
    return 0;
}

template <typename R, typename T>
void print(std::initializer_list<const T> values, const R separator){
    if (values.size() == 0) {
	std::cout << std::endl;
        return;
    }
    for (const auto& value: values) {
	std::cout << value << separator;
    }
}

template <typename T>
void print(T args...) {
    print({args});
}


