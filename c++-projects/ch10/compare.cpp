#include <iostream>

namespace Compare {
    enum class compare: int {
        LessThan = 0,
        EqualTo,
        GreaterThan,
    };

    inline std::ostream& operator<<(std::ostream& os, const compare& c) {
        switch (c) {
            case compare::EqualTo:
                os << 0;
                break;
            case compare::GreaterThan:
                os << 1;
                break;
            case compare::LessThan:
                os << -1;
                break;
            default:;
        }
        return os;
    }
}
