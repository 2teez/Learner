#ifndef _ENUM_CLASS_PRAC_
#define _ENUM_CLASS_PRAC_

namespace operation {
    enum class Operation {
        Add,
        Subtract,
        Multiply,
        Divide,
    };

    class OperationalError {};
}

struct Calculator {
    Calculator() = delete;
    explicit Calculator(const operation::Operation&);

    int calculate(int, int);
    private:
        operation::Operation op;
};

#endif //_ENUM_CLASS_PRAC_
