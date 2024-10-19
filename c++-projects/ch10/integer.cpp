
#include "integer.h"

Integer::Integer(int value): value {value} {}
Integer::Integer(const Integer& i): value {i.get_value()} {
    std::cout << value << " in Copy Constructor.." << '\n';
}
void Integer::set_value(int pvalue) {
    value = pvalue;
}

int Integer::get_value() const {
    return value;
}

Compare::compare Integer::compare(const Integer& i) const {
    Compare::compare result {Compare::compare::EqualTo};
    if (value < i.get_value())
        result = Compare::compare::LessThan;
    else if (value > i.get_value())
        result = Compare::compare::GreaterThan;
    //else result = Compare::compare::EqualTo;
    return result;
}

std::ostream& operator<<(std::ostream& os, const Integer& num) {
    os << num.get_value() << std::endl;
    return os;
}
