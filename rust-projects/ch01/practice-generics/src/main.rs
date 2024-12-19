#[allow(dead_code)]
mod traits_prac;
use crate::traits_prac::{Animal, In1, Pig, TestStruct};

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
}
