#include <iostream>
#include <sstream>

int main(int argc, char** argv) {

    std::stringstream slist, sNum;
    std::string numbers ("1.1, 2.2, 3.3");

    slist.clear();
    slist.str(numbers);
    return 0;
}
