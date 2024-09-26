#include "human.h"
#include <iostream>

Human::Human(int strength, int hit)
    : Creature(strength, hit, type), type("Human"), strength(strength), hit(hit)
    {}

const std::string& Human::get_type() const {
    return type;
}

int Human::get_strength() const {
        return strength;
}

int Human::get_hit() const{
        return hit;
}

int Human::get_damage() const {
    int damage;
    damage = (rand() % strength) + 1;
    std::cout << type << " attacks for " <<
              damage << " points!" << std::endl;
    return damage;
    }

std::ostream& operator<<(std::ostream& os, const Human& creature) {
    os << "Creature {type: " << creature.type
    << ", strength: " << creature.strength
    << ", damage: " << creature.hit
    << "}" << std::endl;
    return os;
}
