
#include <iostream>
#include <cstddef>
#include <memory>

template <typename TR, typename T, typename R>
TR larger(T a, R b);

template <typename T, int N>
T average(const T(&arr)[N]);

int main(int argc, char** argv) {

    std::cout << larger<int>(4, 0.45) << '\n';
    std::shared_ptr<int> sptr1 = std::make_shared<int>(32),
    sptr2 = std::make_shared<int>(45);
    std::cout << *larger<std::shared_ptr<int> >(sptr1, sptr2) << '\n';
    std::cout << larger<int>(34, 27) << '\n';

    // find avearge
    int integers[] = {6,0,2,5,8,3,1};
    double doubles[] = {4.2,8.17,0.23,5.82, 3.11};
    std::cout << average(integers) << "\n";
    std::cout << average(doubles) << "\n";
    return 0;
}

template <typename T, int N>
T average(const T(&arr)[N]) {
    T sum {};
    for (size_t i {}; i < N; ++i) {
        sum += arr[i];
    }
    return sum/N;
}

template <typename TR, typename T, typename R>
TR larger(T a, R b) {
    return a  > b ? a : b;
}
