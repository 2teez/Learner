
#ifndef DEMON_H
#define DEMON_H

#include "creature.h"

class Demon: public Creature {
    public:
        Demon() = delete;
        Demon(int, int, const std::string& = "Demon");
        const std::string& get_type() const;
        int get_strength() const;
        int get_hit() const;
        int get_damage() const;
        friend std::ostream& operator<<(std::ostream&, const Demon&);

    private:
        std::string type = "Demon";
        int strength;
        int hit;
};

#endif // DEMON_H
