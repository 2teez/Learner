#[derive(Debug)]
pub struct Pig;
pub struct TestStruct;

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

pub trait In1 {
    const A: u32;
    fn display(&self) {
        println!("Greek!");
    }
}

impl In1 for TestStruct {
    const A: u32 = 34;
}
