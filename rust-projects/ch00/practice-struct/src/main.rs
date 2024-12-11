#![allow(dead_code)]

#[derive(Debug)]
struct Person {
    name: String,
    age: u32,
}

#[derive(Debug)]
struct Colour(u32, u32, u32);

fn main() {
    let raw_p = Person {
        name: "java".to_owned(),
        age: 35,
    };
    println!("{}, {}", raw_p.name, raw_p.age);
    let from_fn = new_person("rusty", 10);
    println!("{:?}", from_fn);

    let color = Colour(154, 200, 105);
    println!("{:#?}", color);
}

fn new_person(name: &str, age: u32) -> Person {
    Person {
        age,
        name: name.to_owned(),
    }
}

fn get_input(msg: &str) -> String {
    use std::io;

    let mut line = String::new();
    print!("{}", msg);
    io::stdin()
        .read_line(&mut line)
        .expect("Failure to read line");
    line.trim().to_owned()
}
