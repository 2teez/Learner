#![allow(dead_code)]

fn main() {
    println!("{}", add_two_numbers(3, 8));
}

fn add_two_numbers<T: std::ops::Add<Output = T>>(x: T, y: T) -> T {
    x + y
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn add_numbers() {
        assert_eq!(add_two_numbers(2, 2), 4, "addition works");
    }

    #[test]
    //#[ignore]
    #[should_panic(expected = "add two unisigned numbers")]
    fn add_numbers_panics() {
        assert_eq!(add_two_numbers(23, 3), 30, "forbbiden addition");
    }
}
