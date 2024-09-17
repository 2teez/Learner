
#include <iostream>
#include <cctype>
#include <cmath>
#include <stdexcept>
#include "money.h"

static std::string& titlecase(std::string& str);

Money::Money(int unit, double fraction, std::string name):
unit(unit), fraction(fraction), name(titlecase(name)){}

const std::string& Money::get_name() const
{
    return name;
}

int Money::get_unit() const
{
    return unit;
}
double Money::get_fraction() const
{
    return fraction;
}

bool Money::operator==(const Money& m)
{
    return name == m.name;
}

const Money Money::operator+(const Money& m) const
{
    if (name == m.name)
    {
        return Money(unit + m.unit, fraction + m.fraction);
    }
    throw std::runtime_error("Can't add two different Money type");
}

const Money Money::operator-(const Money& m) const
{
    if (name == m.name)
    {
        return Money(unit - m.unit, fraction - m.fraction);
    }
    throw std::runtime_error("Can't subtract two different Money type");
}

std::ostream& operator<<(std::ostream& os, const Money& m)
{
    if (m.unit != 0)
        os << m.unit << "."<< std::abs(m.fraction) << " "<< m.name;
    else
        os << m.unit << "."<< m.fraction << " "<< m.name;
    return os;
}

static std::string& titlecase(std::string& str)
{
    // if the string is empty
    if (str.size() == 0) return str;
    *str.begin() = std::toupper(*str.begin());
    for(auto s = str.begin()+1, e = str.end(); s != e; ++s)
        *s = std::tolower(*s);
    return str;
}
