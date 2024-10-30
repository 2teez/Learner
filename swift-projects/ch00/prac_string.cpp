
#include <iostream>
#include <string>
#include <tuple>

enum class Planets {
    Mercury,
    Venus,
    Earth,
};

int main(int argc, char** argv) {

    std::string path {"one/two/three/four"};
    std::cout << path.substr(0, 4)<< '\n';
    std::cout << path.substr(4) << '\n';
    std::cout << path.length() << '\n';

    auto place {Planets::Earth};
    switch (place) {
       case Planets::Earth:
           std::cout << "Earth";
           break;
       default:
           break;
    }

    auto person = std::make_tuple("omit",
        23, "cpp");

    std::cout << std::get<2>(person) << '\n';

    return 0;
}
