#include "printer.h"

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


