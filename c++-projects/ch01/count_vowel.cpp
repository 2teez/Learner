
#include <iostream>
#include <cstddef>
#include <stdexcept>
#include <string>

struct MyString {
    const std::string head();
    const std::string& last();
    const std::string& tail();
    const std::string& get_string();

    MyString(const std::string& s): str{s}
    {}
    private:
        std::string str;
};

int main(int argc, char** argv)
{
    // enter a sentence from CLI
    MyString str("timothy");
    try
    {
        std::cout << str.head() << std::endl;
    } catch (const std::runtime_error& err)
    {
        std::cout << err.what() << std::endl;
    }
    auto vowel_counter = 0;
    std::string line("");

    while(getline(std::cin,line) && line != ".")
    {
        for (auto letter: line)
        {
            if (isupper(letter))
            {
                letter = toupper(letter);
            }
            switch (letter)
            {
                case 'a': case 'e': case 'i': case 'o': case 'u':
                    ++vowel_counter;
                    break;
                default:
                    break;
            }
        }
    }

    std::cout << "The number of vowel in the statement "
    " is " << vowel_counter << std::endl;

    return 0;
}

const std::string MyString::head()
{
    std::string result("");
    if (!str.empty())
    {
        result = std::string(1, *str.cbegin());
    }
    else
    {
        throw std::runtime_error(str + " is an empty string.");
    }
    return result;
}
