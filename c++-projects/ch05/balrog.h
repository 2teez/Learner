#ifndef BALROG_H
#define BALROG_H

#include "demon.h"
#include <string>

class Balrog: public Demon {
    public:
        Balrog() = delete;
        Balrog(std::string, int, int);
        std::string get_type() const;
        int get_strength() const;
        int get_hit() const;
        int get_damage();

    private:
        std::string type = "Balrog";
        int strength;
        int hit;
};

#endif // BALROG_H
