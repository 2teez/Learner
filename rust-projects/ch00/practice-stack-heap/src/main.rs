#![allow(dead_code)]

fn main() {
    let x = 5;
    let y = x;

    println!("x: {x}, y: {y}");

    let s1 = "Hello".to_string();
    let s2 = s1.clone();
    println!("s1: {s1},\n s2: {s2}");

    println!("{} is the length of the string {}", calculate_len(&s2), s2);

    // using mutable string and making reference from such
    let mut an_str = String::from("howdy");
    let r1 = &an_str; // immutable reference string
    let r2 = &r1; // another immutable ref
    println!("{}, {}", r1, r2);
    changes(&mut an_str);
    println!("{an_str}");
}

fn calculate_len(str: &String) -> usize {
    str.len()
}

fn changes(str: &mut String) {
    str.push_str(", world!");
}
