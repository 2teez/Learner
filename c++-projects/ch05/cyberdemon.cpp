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
