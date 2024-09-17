
#include <iostream>
#include <vector>
#include <string>

void twice(int&);
template <typename T>
void print_vec(std::vector<T>);

int main(int argc, char** argv)
{
    std::vector<int> ivec {1,2,3,4,5,6,7,8,9,10};
    for(auto i = ivec.begin(); i != ivec.end(); ++i)
    {
        twice(*i);
    }

    print_vec(ivec); // print vector
    // get words from cl
    std::vector<std::string> wvec;
    std::string wrd("");
    std::cout << "Enter (qQ - Quit)> ";
    while(getline(std::cin, wrd))
    {
        if (wrd == "qQ")
            break;
        wvec.push_back(wrd);
        std::cout << "Enter (qQ - Quit)> ";
    }

    print_vec(wvec);

    return 0;
}

void twice(int& number)
{
    number *= number;
}

template <typename T>
void print_vec(std::vector<T> vec)
{
    // using while loop
    auto i = vec.cbegin();
    while(i != vec.cend())
    {
        std::cout << *i;
        ++i;
    }
    std::cout << std::endl;
}
