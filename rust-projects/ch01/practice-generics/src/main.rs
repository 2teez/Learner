#![allow(dead_code)]
mod traits_prac;
use crate::traits_prac::{Animal, In1, Pig, TestStruct};
mod traits_prac2;
use crate::traits_prac2::*;

fn main() {
    dbg!("{:#?}", "aeiou".chars().collect::<Vec<_>>());

    let pig = Pig;
    println!("{:?}", pig);
    pig.animal_sound();
    pig.sleep();
    //==========
    let teststruct = TestStruct;
    teststruct.display();
    println!("{}", TestStruct::A);
    //=========
    let mut bicycle = Bicycle::new(0, 0);
    bicycle.change_gear(2);
    bicycle.speed_up(3);
    bicycle.apply_brakes(1);

    println!("Bicycle present state :");
    print_vehicle_info(&bicycle);

    // creating instance of the bike.
    let mut bike = Bike::new(0, 0);
    bike.change_gear(1);
    bike.speed_up(4);
    bike.apply_brakes(3);

    println!("Bike present state :");
    print_vehicle_info(&bike);
}
