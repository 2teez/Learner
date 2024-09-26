#ifndef BALROG_H
#define BALROG_H

#include "demon.h"

class Balrog: public Demon {
    public:
        Balrog() = delete;
        Balrog(int, int, const std::string& = "Balrog");
        const std::string& get_type() const override;
        int get_strength() const;
        int get_hit() const;
        int get_damage() const override;

    private:
        std::string type = "Balrog";
        int strength;
        int hit;
};

#endif // BALROG_H
