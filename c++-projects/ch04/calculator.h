#ifndef __CALCULATOR_H__
#define __CALCULATOR_H__

#include <iostream>

class Calculator {
    public:
        Calculator() = delete;
        Calculator(double, double);
        friend std::ostream& operator<<(std::ostream&, const Calculator&);
        Calculator& operator+(const Calculator&);
    private:
        double left_value = 0;
        double right_value = 0;
};

#endif //__CALCULATOR_H__
