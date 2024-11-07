#include "transport.h"
#include <iostream>

class Car: public transport {
    public:
        Car() = delete;
        Car(float speed, float fuel_capacity):
        transport{speed, "Gasoline"}, speed {speed},
        fuel_capacity {fuel_capacity} {}

        float max_distance() const override {
            return fuel_capacity * 15;  // assuming 15 km per liter
        }

        std::string description() const override {
            std::string str {"Car with a top speed of "};
            str += std::to_string(speed) + " km/h and max range " + std::to_string(max_distance()) +" km.";
            return str;
        }

        ~Car() {
            std::cout << "Car Destructor called..." << '\n';
        }
    private:
        float speed;
        float fuel_capacity;
};
