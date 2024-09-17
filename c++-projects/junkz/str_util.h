
#ifndef __STR_UTIL_H__
#define __STR_UTIL_H__

#include <string>
#include <ostream>

namespace MyString
{
    std::ostream& operator<< (std::ostream& out, const std::string&);
}

#endif //__STR_UTIL_H__
