
#include <iostream>
#include <memory>
#include <stdexcept>

class Animal {
    public:
        virtual void make_sound() = 0;
        void sleep() {
            std::cout << "The animal is sleeping" << '\n';
        }
        virtual ~Animal() = 0;
};

Animal::~Animal() {} // implementation of Animal destructor

class Dog: public Animal {
    public:
        void make_sound() override {
            std::cout << "Woof" << '\n';
        }
    ~Dog() {
        std::cout << "Dog destructor called\n";
    }
};

struct Lion: public Animal {
    public:
        void make_sound() override {
            std::cout << "Roarrr..." << '\n';
        }

        ~Lion() {
            std::cout << "Lion destructor called\n";
        }
};

void make_a_sound(const std::shared_ptr<Animal>& an) {
    try {
        an->make_sound();
    } catch(std::runtime_error e) {
        std::cout << e.what() << '\n';
    }
}

int main(int argc, char** argv) {
    Dog my_dog;
    my_dog.make_sound();
    my_dog.sleep();

    auto lion {Lion{}};

    std::shared_ptr<Animal> my_dog_ptr = std::make_shared<Dog>(my_dog);
    std::shared_ptr<Animal> my_lion_ptr = std::make_shared<Lion>(lion);

    make_a_sound(my_lion_ptr);
    make_a_sound(my_dog_ptr);

    return 0;
}
