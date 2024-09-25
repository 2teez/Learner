#include <iostream>
#include <sstream>
#include <string>

int main(int argc, char** argv) {

    std::stringstream slist, sNum;
    std::string numbers ("1.1, 2.2, 3.3");

    slist.clear();
    slist.str(numbers);

    double value, total = 0;
    std::string field;
    while(std::getline(slist, field, ',')) {
        sNum.str(field);
        sNum >> value;
        total += value;
    }
    std::cout << "Total: " << total << std::endl;
    return 0;
}
