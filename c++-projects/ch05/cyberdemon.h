#ifndef CYBERDEMON_H
#define CYBERDEMON_H

#include "demon.h"

class CyberDemon: public Demon {
    public:
        CyberDemon() = delete;
        CyberDemon(int, int, const std::string& = "CyberDemon");
        const std::string& get_type() const override;
        int get_strength() const;
        int get_hit() const;
        virtual int get_damage() const override;

    private:
        std::string type = "CyberDemon";
        int strength;
        int hit;
};

#endif // CYBERDEMON_H
