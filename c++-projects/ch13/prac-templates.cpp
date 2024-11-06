
#include <iostream>
#include <cstddef>

//template <typename T>
struct Person {
  public:
    Person():name{"Doe"}, age{0}{}
    template <typename U>
    U getAge() const {
        return static_cast<U>(age);
    }
  private:
    std::string name {};
    int age {};
};

int main(int argc, char** argv) {
    Person p;
    std::cout << p.getAge<double>() << "\n";

    return 0;
}
