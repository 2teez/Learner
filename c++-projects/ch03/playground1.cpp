#include <iostream>
#include <vector>

class NoDefault
{
    public:
        NoDefault() = delete;
        NoDefault(int i): i(i) {}
        int get() const { return i; }
    private:
        int i;
};

class C
{
    public:
        C(): nd(0) {};
        const int get() const { return nd.get(); }

    private:
        NoDefault nd;
};

struct Person
{
    int age;
    std::string name;
};

int main(int argc, char** argv)
{
    C c;
    std::cout << c.get() << std::endl;
    NoDefault nd(3);

    NoDefault ndd(nd);
    std::cout << ndd.get() << "\n";

    Person tm = {23, "mit"};
    std::cout << tm.age;

   return 0;
}
