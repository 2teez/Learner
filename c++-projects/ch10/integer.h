#ifndef _INTEGER_
#define _INTEGER_

#include <iostream>
#include "compare.cpp"

class Integer {
    public:
        Integer() = default;
        explicit Integer(int);
        explicit Integer(const Integer&);
        void set_value(int);
        int get_value() const;
        static void printCount();
        Compare::compare compare(const Integer&) const;
        Integer& operator+(const Integer&);
        Integer& operator-(const Integer&);
        Integer& operator*(const Integer&);

        friend std::ostream& operator<<(std::ostream&, const Integer&);

    private:
            int value {};
            static inline int get_instance {};
};

#endif //_INTEGER_
