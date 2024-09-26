
#include <iostream>
#include "human.h"
#include "cyberdemon.h"
#include "elf.h"
#include "balrog.h"

void show_creature(const Creature&);

int main(int argc, char** argv) {
    Creature creature(4, 5);
    std::cout << creature;
    std::cout << creature.get_type() << std::endl;

    Human tim(2, 10);
    std::cout << tim;
    std::cout << tim.get_type() << std::endl;

    Demon demon(7, 21);
    show_creature(demon);

    return 0;
}

void show_creature(const Creature& creature) {
   std::cout << creature;
   std::cout << creature.get_type() << std::endl;
   std::cout << creature.get_damage() << std::endl;
}
