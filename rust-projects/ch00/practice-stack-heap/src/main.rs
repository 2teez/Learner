#![allow(dead_code)]

fn main() {
    let x = 5;
    let y = x;

    println!("x: {x}, y: {y}");

    let s1 = "Hello".to_string();
    let s2 = s1.clone();
    println!("s1: {s1},\n s2: {s2}");

    println!("{} is the length of the string {}", calculate_len(&s2), s2);
}

fn calculate_len(str: &String) -> usize {
    str.len()
}
