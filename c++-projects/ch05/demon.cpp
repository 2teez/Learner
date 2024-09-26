#include "demon.h"
#include <iostream>

Demon::Demon(int strength, int hit, const std::string& type)
    : Creature(strength, hit, type), type("Demon"), strength(strength), hit(hit)
    {}

const std::string& Demon::get_type() const {
    return type;
}

int Demon::get_strength() const {
        return strength;
}

int Demon::get_hit() const{
        return hit;
}

int Demon::get_damage() const {
    int damage;
    damage = (rand() % strength) + 1;
    std::cout << type << " attacks for " <<
              damage << " points!" << std::endl;
    if ((rand( ) % 100) < 5) {
        damage = damage + 50;
        std::cout << "Demonic attack inflicts 50 "
        << " additional damage points!" << std::endl;
    }
    return damage;
}

std::ostream& operator<<(std::ostream& os, const Demon& creature) {
    os << "Creature {type: " << creature.type
    << ", strength: " << creature.strength
    << ", damage: " << creature.hit
    << "}" << std::endl;
    return os;
}
