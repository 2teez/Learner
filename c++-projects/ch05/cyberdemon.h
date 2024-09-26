#ifndef CYBERDEMON_H
#define CYBERDEMON_H

#include "demon.h"

class CyberDemon: public Demon {
    public:
        CyberDemon() = delete;
        CyberDemon(int, int, const std::string&);
        const std::string& get_type() const;
        int get_strength() const;
        int get_hit() const;
        //int get_damage();

    private:
        std::string type = "CyberDemon";
        int strength;
        int hit;
};

#endif // CYBERDEMON_H
