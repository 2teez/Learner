
#ifndef CREATURE_H
#define CREATURE_H

#include <iostream>
#include <string>

class Creature {
    public:
        Creature() = delete;
        Creature(int, int, const std::string& = "Creature");
        const std::string& get_type() const;
        int get_strength() const;
        int get_hit() const;
        int get_damage() const;
        friend std::ostream& operator<<(std::ostream&, const Creature&);

    private:
        const std::string type = "Creature";
        int strength = 0;
        int hit = 0;
};

#endif // CREATURE_H
