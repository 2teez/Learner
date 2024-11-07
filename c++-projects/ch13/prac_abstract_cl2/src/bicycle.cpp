#include "transport.h"
#include <iostream>

class Bicycle: public transport {
    public:
        Bicycle() = delete;
        Bicycle(float speed, float fuel_capacity = 50):
        transport{speed, "Human Power"}, speed {speed},
        fuel_capacity {fuel_capacity} {}

        float max_distance() const override {
            return 50;  // assuming 15 km per liter
        }

        std::string description() const override {
            std::string str {"Bicycle with a top speed of "};
            str += std::to_string(speed) + " km/h and max range " + std::to_string(max_distance()) +" km.";
            return str;
        }

        ~Bicycle() {
            std::cout << "Bicycle Destructor called..." << '\n';
        }
    private:
        float speed;
        float fuel_capacity;
};
