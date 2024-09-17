#ifndef __MONEY_H__
#define __MONEY_H__

#include <string>
#include <ostream>

class Money
{
    public:
        Money() = delete;
        Money(int, double, std::string = "Naira");
        const std::string& get_name() const;
        int get_unit() const;
        double get_fraction() const;
        bool operator==(const Money&);
        //bool operator<(const Money&);
        //bool operator>(const Money&);

        const Money operator+(const Money&) const;
        const Money operator-(const Money&) const;

        friend std::ostream& operator<<(std::ostream&, const Money&);

    private:
        int unit = 0;
        double fraction = 0;
        std::string name;

};

#endif //__MONEY_H__
