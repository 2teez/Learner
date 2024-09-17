#include <iostream>
#include <stdexcept>

class PrimeNumber
{
    public:
        PrimeNumber(): number(1) {}
        PrimeNumber(unsigned number): number(check_number(number)){}
        friend std::ostream& operator<<(std::ostream& os, const PrimeNumber& pm)
        {
            os << pm.number;
            return os;
        }
        unsigned get_prime_number() const;

        PrimeNumber operator++();  //prefix
        PrimeNumber operator++(int);  //postfix

        PrimeNumber operator--();  //prefix
        PrimeNumber operator--(int);  //postfix

    private:
        unsigned number;
        unsigned check_number(unsigned number)
        {
            unsigned limit = number / 2;
            for (unsigned i = 2; i <= limit; ++i)
            {
                if (0 == (number % i))
                  return 1;
            }
            return number;
        }
};

int main(int argc, char** argv)
{

    PrimeNumber pm, pm2 = {7919};

    std::cout << pm++ << pm2 << "\n" << pm++ << pm++ << pm << "\n";
    std::cout << pm2 << ":"<< ++pm2 << "\n";

    PrimeNumber pmarr[] = {PrimeNumber(1), 2, PrimeNumber(5), PrimeNumber(7),
        PrimeNumber(23), PrimeNumber(7919), PrimeNumber(7927)};

    for (auto number: pmarr)
        std::cout << --number++ << number << "\n";

    PrimeNumber p{13};
    std::cout << p << ":" << --p << ":" << p-- << ":" << p << std::endl;

    return 0;
}

PrimeNumber PrimeNumber::operator++()
{
    ++number;
    while(check_number(number) == 1)
        ++number;
    return PrimeNumber(number);
}

PrimeNumber PrimeNumber::operator++(int ignoreMe)  //postfix
{
    unsigned tmp = number;
    number++;
    while(check_number(number) == 1)
    {
        //tmp = number;
        number++;
    }
    return PrimeNumber(tmp);
}

PrimeNumber PrimeNumber::operator--()
{
    --number;
    while(number > 0 && check_number(number) == 1)
        --number;
    return PrimeNumber(number);
}

PrimeNumber PrimeNumber::operator--(int ignoreMe)  //postfix
{
    unsigned tmp = number;
    number--;
    while(number > 0 && check_number(number) == 1)
    {
        //tmp = number;
        number--;
    }
    return PrimeNumber(tmp);
}
