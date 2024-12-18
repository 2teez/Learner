use practice_err::get_filename;
use std::fs::File;
use std::io::{self, ErrorKind};

fn main() {
    // using match on Err
    let file = File::open(get_filename("Enter filename: "));
    match file {
        Ok(f) => println!("{:?}", f),
        Err(err) => match err.kind() {
            ErrorKind::NotFound => match File::create("n_log.txt") {
                Ok(f) => println!("{:?}", f),
                Err(e) => panic!("{:?}", e),
            },
            others => panic!("{:?}", others),
        },
    }
}
