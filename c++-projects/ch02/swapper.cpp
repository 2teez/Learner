#include <iostream>
#include <string>
#include <initializer_list>

void swapper(int&, int&, const std::string="Ref Swapper");

template <typename T>
void swapper(T*, T*, const std::string="Pointer Swapper");

template <typename T>
void pprint(const std::string& msg, std::initializer_list<T>);

int main(int argc, char** argv)
{

    int num1 = 12, num2 = 21;
    pprint<int>("Before Value Swaps: ", {num1, num2});
    swapper(num1, num2, "Using Reference: ");

    pprint<int>("After Value Swaps: ", {num1, num2});

    // using pointer
    pprint<int>("Before Value Swaps: ", {num1, num2});
    swapper<int>(&num1, &num2);

    pprint<int>("After Value Swaps: ", {num1, num2});

    // using std::string
    std::string str1("cpp is a langauge to learn"),
                str2("others also can be used.");

    pprint<std::string>("Before Value Swaps: ", {str1, str2});
    swapper<std::string>(&str1, &str2, "Using Ponter: ");

    pprint<std::string>("After Value Swaps: ", {str1, str2});


    return 0;
}

template <typename T>
void pprint(const std::string& msg, std::initializer_list<T> data)
{
    auto beg = data.begin(),
         end = data.end();
    std::cout << msg << std::endl;
    while(beg != end)
    {
        std::cout << *beg << std::endl;
        ++beg;
    }
    std::cout << std::endl;
}

void swapper(int& number1, int& number2, const std::string msg)
{
    std::cout << msg << std::endl;
    auto temp = number1;
    number1 = number2;
    number2 = temp;
}

template <typename T>
void swapper(T* number1, T* number2, const std::string msg)
{
    std::cout << msg << std::endl;
    auto temp = *number1;
    *number1 = *number2;
    *number2 = temp;
}
