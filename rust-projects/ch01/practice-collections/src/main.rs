use practice_collections::*;

fn main() {
    println!("Pig lain Game!");
    loop {
        let word = gets("Enter a word");
        if word != "exit".to_owned() {
            println!("{}", pig_latin(&word))
        } else {
            break;
        }
    }
}
