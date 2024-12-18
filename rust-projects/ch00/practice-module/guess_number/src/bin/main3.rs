#![allow(dead_code)]

use guess_number::{random_number, user_input};
use rand::Rng;
use std::cmp::Ordering;

fn main() {
    println!("Guessing Game:");
    let guess_number: u32 = random_number(0, 100);
    loop {
        let user_number: u32 = match user_input("Enter guess number: ").trim().parse() {
            Ok(num) => num,
            Err(_) => continue,
        };
        println!(
            "{}\n",
            match user_number.cmp(&guess_number) {
                Ordering::Less => "Less than",
                Ordering::Greater => "Greater Than",
                Ordering::Equal => {
                    "Equal";
                    break;
                }
            }
        );
    }
}
