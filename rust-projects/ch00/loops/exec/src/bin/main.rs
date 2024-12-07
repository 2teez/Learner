#![allow(dead_code)]

fn main() {
    let num: f64 = get_user_input("Enter Temperature: ")
        .trim()
        .parse()
        .expect("Not a number");
    println!("{} in Celisus: {}", num, fahrenheit_to_celsius(num));
    println!("{} in Fahrenheit: {}", num, celsius_to_fahrenheit(num));
}

fn get_user_input(msg: &str) -> String {
    use std::io;
    print!("{}", msg);
    let mut line = String::new();
    io::stdin()
        .read_line(&mut line)
        .expect("Failed to read line")
        .to_string();
    return line;
}

fn celsius_to_fahrenheit(temp: f64) -> f64 {
    temp * 9.0 / 5.0 + 32_f64
}

fn fahrenheit_to_celsius(temp: f64) -> f64 {
    (temp - 32_f64) * 5_f64 / 9_f64
}
