#include <iostream>
#include <memory>

//void do_something(std::auto_ptr<int> data) {
void do_something(std::shared_ptr<int> data) {
    *data = 11;
}

int main(int argc, char** argv) {
    std::shared_ptr<int> mytest{new int{10}};
    do_something(mytest);
    std::cout << *mytest << "\n";
    *mytest = 13;
    std::cout << *mytest << "\n";
    return 0;
}
