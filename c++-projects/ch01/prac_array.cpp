
#include <iostream>
#include <cstddef>
#include <string>
#include <vector>

template <typename T>
void print_arr(size_t, T*, std::string=",");

template <typename T>
void print_vec(std::vector<T>);

int main(int argc, char** argv)
{
    constexpr size_t len = 11;
    int arr[len] = {};

    // fill array
    for (size_t i = 0; i < len; ++i)
    {
        arr[i] = i;
    }

    print_arr(len, arr, ", ");
    std::string langs[] = {"elixir", "cpp", "zig-lang", "rust"};
    unsigned int size = sizeof(langs)/sizeof(langs[0]);

    print_arr(size, langs, ", ");
    // copy an array into another array
    int arr_copy[len] = {};
    print_arr(len, arr_copy, "|");
    // copying
    int index = 0;
    for (auto value: arr)
        arr_copy[index++] = value;
    print_arr(len, arr_copy, "|");

    // using vector
    std::vector<int> values(11, 0);
    print_vec(values);
    for (std::vector<int>::size_type i = 0; i < values.size(); ++i)
    {
        values[i] = i;
    }
    print_vec(values);
    // copy to a new vector
    std::vector<int> values_copy = values;
    print_vec(values_copy);

    // initializing an array
    // print out the content of array using
    // pointer and iterator namely begin and end
    int carr[] = {4,8,2,9,12,4};

    for(auto beg = std::begin(carr), end = std::end(carr); *beg != *end; ++beg)
    {
        std::cout << *beg;
    }
    std::cout << std::endl;

    unsigned nsize = sizeof(carr)/sizeof(carr[0]);
    for (auto beg = carr, end = beg+nsize; *beg != *end; ++beg)
    {
        *beg = 0;
    }
    print_arr(nsize, carr, "][");

    return 0;
}

template <typename T>
void print_arr(size_t len, T* arr, std::string sep)
{
    for(size_t i = 0; i < len; ++i)
    {
        if (i < len-1)
            std::cout << arr[i] << sep;
        else std::cout << arr[i];
    }
    std::cout << std::endl;
}

template <typename T>
void print_vec(std::vector<T> vec)
{
    for (auto value : vec)
    {
        std::cout << value;
    }
    std::cout << std::endl;
}
