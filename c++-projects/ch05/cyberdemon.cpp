#include "cyberdemon.h"

CyberDemon::CyberDemon(int strength, int hit, const std::string& type)
    : Demon(strength, hit, type), type("Demon"), strength(strength), hit(hit)
    {}

const std::string& CyberDemon::get_type() const {
    return type;
}

int CyberDemon::get_strength() const {
        return strength;
}

int CyberDemon::get_hit() const{
        return hit;
}

int CyberDemon::get_damage() const {
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
