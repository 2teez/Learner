
#include "str_util.h"

namespace MyString
{
    std::ostream& operator<< (std::ostream& out, const std::string& str)
    {
        out << str;
        return out;
    }
}
