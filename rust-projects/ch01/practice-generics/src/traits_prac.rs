#[derive(Debug)]
pub struct Pig;

pub trait Animal {
    fn animal_sound(&self);
    fn sleep(&self) {
        println!("{}", "Zzz");
    }
}

impl Animal for Pig {
    fn animal_sound(&self) {
        println!("The pig says {}", "wee..wee");
    }
}
