
#include <iostream>
#include "human.h"
#include "cyberdemon.h"
#include "elf.h"
#include "balrog.h"

template <typename T>
void show_creature(const T&);

void show_diff_creatures(const Creature*);

int main(int argc, char** argv) {
    Creature creature(4, 5);
    std::cout << creature;
    std::cout << creature.get_type() << std::endl;

    Human tim(2, 10);
    std::cout << tim;
    std::cout << tim.get_type() << std::endl;

    Demon demon(7, 21);
    show_creature(demon);

    show_creature(CyberDemon {7, 41});
    //show_creature(Balrog {7, 41});

    Human* cr = new Human(10, 10);
    show_diff_creatures(cr);

    Demon* de = new CyberDemon(2, 50);
    show_diff_creatures(de);

    //cr = de;
    //show_diff_creatures(cr);

    delete cr;
    //delete de;

    return 0;
}

template <typename T>
void show_creature(const T& creature) {
   std::cout << creature;
   std::cout << creature.get_type() << std::endl;
   std::cout << creature.get_damage() << std::endl;
}

void show_diff_creatures(const Creature* creature) {
    std::cout << *creature;
    std::cout << creature->get_type() << std::endl;
    std::cout << creature->get_damage() << std::endl;
}
