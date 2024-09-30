
#include <iostream>
#include <vector>

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
    return 0;
}
