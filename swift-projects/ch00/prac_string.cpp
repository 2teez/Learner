
#include <iostream>
#include <string>

int main(int argc, char** argv) {

    std::string path {"one/two/three/four"};
    std::cout << path.substr(0, 4)<< '\n';
    std::cout << path.substr(4) << '\n';
    return 0;
}
