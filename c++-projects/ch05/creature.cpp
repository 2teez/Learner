#include "creature.h"
#include <cstdlib>
#include <iostream>

Creature::Creature(int strength, int hit, const std::string& type)
    : type("Creature"), strength(strength), hit(hit)
    {}

const std::string& Creature::get_type() const {
    return type;
}

int Creature::get_strength() const {
        return strength;
}

int Creature::get_hit() const{
        return hit;
}

int Creature::get_damage() const {
    int damage;
    damage = (rand() % strength) + 1;
    std::cout << get_type( ) << " attacks for " <<
              damage << " points!" << std::endl;
    return damage;
}

std::ostream& operator<<(std::ostream& os, const Creature& creature) {
    os << "Creature {type: " << creature.type
    << ", strength: " << creature.strength
    << ", damage: " << creature.hit
    << "}" << std::endl;
    return os;
}
