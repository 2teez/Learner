
#include <iostream>
#include <vector>

struct Pet {
    explicit Pet(const std::string& name): name(name) {}
    explicit Pet(const Pet&);
    const Pet& operator=(const Pet&);
    virtual std::string get_name() = 0;
    std::string name;
    ~Pet() {}
};

struct Dog : public Pet {
    explicit Dog(const std::string& name): Pet(name) {}
    virtual std::string get_name() override {
        return name;
    }
};

struct Cat: public Pet {
    explicit Cat(const std::string& name): Pet(name) {}
    explicit Cat(const Cat&);
    const Cat& operator=(const Cat&);
    virtual std::string get_name() override {
        return name;
    }
};

struct Lion : public Cat {
    explicit Lion(const std::string& name): Cat(name) {}
    virtual std::string get_name() final {
        return name;
    }
};

void get_a_pet(Pet* pet) {
    std::cout << pet->get_name() << std::endl;
}

int main(int argc, char** argv) {

    std::vector<Pet*> pets {new Dog("Marvin"), new Cat("olongbo"), new Lion("Simba")};
    for (auto pet: pets) get_a_pet(pet);

    get_a_pet(pets[0]);

    pets[0] = pets[2];

    get_a_pet(pets[0]);

    //Cat kat(pets[2]);
    //get_a_pet(&kat);

    return 0;
}

Pet::Pet(const Pet& pet) {
    name = pet.name;
}

const Pet& Pet::operator=(const Pet& pet) {
    if (name != pet.name) name = pet.name;
    return pet;
}

Cat::Cat(const Cat& pet): Pet(pet) {
    name = pet.name;
}

const Cat& Cat::operator=(const Cat& pet) {
    if (name != pet.name) name = pet.name;
    return pet;
}
