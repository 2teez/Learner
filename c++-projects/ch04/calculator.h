#ifndef __CALCULATOR_H__
#define __CALCULATOR_H__

#include <iostream>

class Calculator {
    public:
        Calculator() = delete;
        explicit Calculator(double);
        friend std::ostream& operator<<(std::ostream&, const Calculator&);
        double operator+(const Calculator&);
    private:
        double value = 0;
};

#endif //__CALCULATOR_H__
