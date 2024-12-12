#![allow(dead_code)]

#[derive(Debug)]
struct Person {
    name: String,
    age: u32,
}

#[derive(Debug)]
struct Colour(u32, u32, u32);

#[derive(Debug, Default)]
struct Rectangle {
    width: u32,
    height: u32,
}

impl Rectangle {
    fn area(&self) -> u32 {
        self.width * self.height
    }
}

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
    // using ordinary tuple
    let ocolor: (u32, u32, u32) = (154, 200, 105);
    println!("{:#?}", ocolor);
    //comparing ordinary variable tuple with struct tuple not the same
    //println!("{:?} <=> {}", color, ocolor == color);

    let rect = Rectangle {
        width: 34,
        height: 13,
    };
    println!("Area: {}, Rectangle {:?}", calculate_area(&rect), rect);
    let rect2 = dbg!(Rectangle { ..rect });
    println!("Area: {}, Rectangle {:?}", calculate_area(&rect2), rect);
    dbg!(&rect);
    println!("Area from rectanglar impl: {}", rect.area());
}

fn calculate_area(rect: &Rectangle) -> u32 {
    rect.width * rect.height
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
