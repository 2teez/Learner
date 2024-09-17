#include <iostream>
#include <cstddef>
#include <string>

struct Person {
    Person() = default;
    Person(const std::string& name): name(name){}
    Person(const std::string& name, const std::string& address);

    std::string get_name() const { return name;}
    std::string get_address() const;

    friend std::ostream& operator<<(std::ostream&, const Person&);

    private:
        std::string name;
        std::string address;
};

std::ostream& print(std::ostream&, const Person& p);

int main(int argc, char** argv)
{
    const Person tom, tim("timothy", "1/1 2A Esson"),
    gbenga("gbenga");

    std::cout << tom.get_name() << tom.get_address();

    print(std::cout, tom);
    print(std::cout, tim);

    std::cout << tim;
    std::cout << gbenga;

    return 0;
}

Person::Person(const std::string& name, const std::string& address): name(name), address(address) {}

std::string Person::get_address() const
{
    return address;
}

std::ostream& print(std::ostream& os,const Person& p)
{
    os << "Name: "<< p.get_name()
    << ", Address: " << p.get_address() << std::endl;
    return os;
}

std::ostream& operator<<(std::ostream& os, const Person& p)
{
    os << "Name: "<< p.get_name()
    << ", Address: " << p.get_address() << std::endl;
    return os;
}
