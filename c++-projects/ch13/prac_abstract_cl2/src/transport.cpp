#include "transport.h"
#include <iostream>

transport::transport(float speed, std::string fuel_type):
   speed{speed}, fuel_type {fuel_type} {}

//inline transport::~transport() {
   // std::cout << "transport destructor called.." << '\n';
//}
