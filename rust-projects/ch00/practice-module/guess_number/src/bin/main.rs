#![allow(dead_code)]
use guess_number::{add, random_number, user_input};

fn main() {
    dbg!(add(5, 8));
    let number = random_number(0, 100);
    dbg!(number);

    let guess_number = random_number(0, 100);
    println!("GUESS: {}", guess_number);
    loop {
        print!("Into guessing number game:");
        let mut user_number: u32 = user_input("Enter your number")
            .trim()
            .parse()
            .expect("Incorrect number");
        while guess_number != user_number {
            println!(
                "{}",
                if user_number > guess_number {
                    format!("{} is greater than {}", user_number, guess_number)
                } else {
                    format!("{} is less than {}", user_number, guess_number)
                }
            );
            user_number = user_input("Enter your number")
                .trim()
                .parse()
                .expect("Incorrect number");
        }
        if guess_number == user_number {
            println!("Congratulations!");
            break;
        }
    }
}
