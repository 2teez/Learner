
#include <iostream>
#include <string>
#include <sstream>

template<typename T>
std::string print(const T value, const std::string& name = " ")
{
    std::ostringstream ss;
    ss << name << ": " << value << " ";
    return ss.str();
}

struct Sales_data {
    std::string bookNo;
    unsigned unit_sold = 0;
    double revenue = 0.0;

    friend std::ostream& operator<<(std::ostream& o, const Sales_data& data)
    {
        o << print(data.bookNo, "Title") <<
        print(data.unit_sold, "Unit ") << print(data.revenue, "Revenue") << std::endl;
        return o;
    }
};

int main(int argc, char** argv)
{
    int* pnum = nullptr,
         num = 34, num2(56);
         pnum = &num;

    std::cout << print(num, "num")
    << print(num2, "num2") << print(pnum, "pointer-num") << std::endl;

    *pnum = num2;

    std::cout << print(num, "num")
    << print(num2, "num2") << print(pnum, "pointer-num") << std::endl;

    //int* val = nullptr;
    decltype(pnum) nnum = &num;
    std::cout << print(nnum, "nnum") << print(*nnum, "nnum") << std::endl;

    Sales_data data, *adata;
    std::cout << print(data) << std::endl;

    return 0;
}
