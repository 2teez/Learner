use practice_err::get_filename;
use std::fs::File;
use std::io::{self, ErrorKind};

fn main() {
    // using match on Err
    let filename = get_filename("Enter filename: ");
    let file = File::open(filename.clone());
    match file {
        Ok(f) => println!("{:?}", f),
        Err(err) => panic!("{:?}", err),
    }

    let file = File::open(filename);
    match file {
        //2
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
