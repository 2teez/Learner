use rand::Rng;
use std::io;

pub fn user_input(msg: &str) -> String {
    print!("{}", msg);
    let mut line = String::new();
    io::stdin()
        .read_line(&mut line)
        .expect("Failure to readline");
    format!("{}", line)
}

pub fn add(left: u64, right: u64) -> u64 {
    left + right
}

pub fn random_number(start: u32, stop: u32) -> u32 {
    rand::thread_rng().gen_range(start..=stop)
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn it_works() {
        let result = add(2, 2);
        assert_eq!(result, 4);
    }

    #[test]
    fn test_guess_number() {
        let expected = random_number(0, 100);
        assert_eq!(expected, 40);
    }

    #[test]
    fn test_user_input() {
        let expected = String::from(user_input("Enter your name:").trim());
        assert_eq!(expected, String::from("java"));
    }
}
