#include <iostream>
#include <vector>
#include <string>
#include <cstddef>

void print_vec(std::vector<int>);
void print_vec_s(std::vector<int>, std::string=",");

// using reference doubled the int value
void doubled_value(int&);

int main()
{
    int arr[] = {8, 4, 2, 6, 1, 0};
    std::vector<int> ivec(std::begin(arr), std::end(arr));
    print_vec(ivec);

    // copy the vector back to array but with the value doubled
    size_t ind = 0;
    for (auto beg = ivec.begin(),end = ivec.end(); beg != end; ++beg)
    {
        doubled_value(*beg); // using a ref to doubled the value
        arr[ind++] = *beg; // copy the new value into array
    }
    // print out the array using pointer begin and end iterator
    // for array
    auto beg = std::begin(arr),
         end = std::end(arr);
    while(beg != end)
    {
        std::cout << *(beg++) << ", ";
    }
    std::cout << std::endl;

    return 0;
}

void print_vec_s(std::vector<int> ivec, std::string sep)
{
    for(auto value : ivec)
    {
        if (*(ivec.cend()) != value)
        {
            std::cout << value << sep;
        }
        else
        {
           std::cout << value;
        }
    }
    std::cout << std::endl;
}

void print_vec(std::vector<int> ivec)
{
    print_vec_s(ivec, ",");
}

void doubled_value(int& value)
{
    value *= value;
}
