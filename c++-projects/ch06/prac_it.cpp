
#include <iostream>
#include <vector>
#include <initializer_list>

namespace sumup {
    template <typename T>
    T sum(std::initializer_list<T> lst) {
        T total {};
        for (auto val : lst) total += val;
        return total;
    }
}
void print_it(const std::vector<int> vec) {
    for (auto const& v: vec)
        std::cout << v << std::endl;
}

int main(int argc, char** argv) {
    std::vector<int> vec;
    for (int i = 0; i <= 4; ++i)
        vec.push_back(i);

    // print vec
    print_it(vec);

    for(std::vector<int>::iterator p = vec.begin(); p != vec.end(); ++p)
        *p = 0;
    print_it(vec);
    std::cout << sumup::sum<double>({3, 7, 3.2, 7.146, 0.23})
    << std::endl;
    std::cout << sumup::sum<int>({3, 7, 8})<< std::endl;

    return 0;
}
