#![allow(dead_code)]
use guess_number::{random_number, user_input};
use std::cmp::Ordering;

fn main() {

    let guess_number = random_number(0, 100);
    println!("GUESS: {}", guess_number);

    loop {
        print!("Into guessing number game:");
        let user_number: u32 = user_input("Enter your number")
            .trim()
            .parse()
            .expect("Incorrect number");

        println!("{}\n", match user_number.cmp(&guess_number) {
            Ordering::Less => "Less Than",
            Ordering::Greater => "Greater Than",
            Ordering::Equal => {"Equals"; break}, 
        });
    }
}
