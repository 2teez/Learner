
#ifndef HUMAN_H
#define HUMAN_H

#include "creature.h"

class Human: public Creature {
    public:
        Human() = delete;
        Human(int, int);
        const std::string& get_type() const;
        int get_strength() const;
        int get_hit() const;
        int get_damage() const;
        friend std::ostream& operator<<(std::ostream&, const Human&);

    private:
        std::string type = "Human";
        int strength = 10;
        int hit = 10;
};

#endif // HUMAN_H
