#include <iostream>
#include <string>
#include <cctype>
#include <sstream>

int main(int argc, char** argv)
{
    std::string str("Here am I now, here I stand!");
    for (auto &c : str)
    {
        if (c == 'e')
        {
            c = 'X';
        }
    }

    std::cout << str << std::endl;

    // using a while loop
    std::string::size_type ind = 0;
    while(ind != str.size())
    {
        if (str[ind] == 'X')
        {
            str[ind] = 'e';
        }
        ind++;
    }

    std::cout << str << std::endl;

    // using A traditional for loop
    for(decltype(str.size()) i = 0; i <= str.size(); i++)
    {
        if (str[i] == 'e')
        {
            str[i] = 'X';
        }
    }
    std::cout << str << std::endl;

    // read thru a string using iterator
    std::string say("Howdy, world ney!!!");
    std::stringstream ss;
    for(auto it = say.begin(); it != say.end(); ++it)
    {
        if (!isspace(static_cast<unsigned char>(*it)))
        {
            ss << static_cast<char>(toupper(static_cast<unsigned char>(*it)));
        }
        else
        {
            ss << *it;
        }

    }
    std::cout << ss.str() << std::endl;

    return 0;
}
