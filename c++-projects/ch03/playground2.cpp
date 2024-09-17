#include <iostream>
#include <string>

void print_arr(const int arr[], const std::size_t, const std::string& sep=",");
int *double_em(int arr[], const std::size_t);

int main(int argc, char** argv)
{

    int arr[] = {6, 4, 8, 2, 7};

    print_arr(arr, sizeof(arr)/sizeof(arr[0]));

    int* n_arr = double_em(arr, sizeof(arr)/sizeof(arr[0]));

    print_arr(n_arr, sizeof(arr)/sizeof(arr[0]), "][");
    print_arr(arr, sizeof(arr)/sizeof(arr[0]), "][");

    return 0;
}

void print_arr(const int arr[], const std::size_t sz, const std::string& sep)
{
    for (std::size_t i = 0; i < sz; ++i)
    {
        std::cout << *(arr+i) << sep;
    }
    std::cout << std::endl;
}

int *double_em(int arr[], const std::size_t sz)
{
    for (std::size_t i = 0; i < sz; ++i)
    {
        arr[i] *= arr[i];
    }
    return arr;
}
