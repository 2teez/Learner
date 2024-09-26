#ifndef ELF_H
#define ELF_H

#include "creature.h"
#include <string>

class Elf: public Creature {
    public:
        Elf() = delete;
        Elf(std::string, int, int);
        std::string get_type() const;
        int get_strength() const;
        int get_hit() const;
        int get_damage();

    private:
        std::string type = "Elf";
        int strength = 5;
        int hit = 5;
};

#endif // ELF_H
