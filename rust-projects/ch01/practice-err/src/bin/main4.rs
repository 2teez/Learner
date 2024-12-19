use practice_err::*;
use std::fs::File;
use std::io::{self, Read};

fn main() {
    println!(
        "{:?}",
        match read_from_file_manually(&get_filename("Enter filename: ")) {
            Ok(filestr) => filestr,
            Err(e) => format!("{:?}", e),
        }
    );
    println!("\n========\n");
    println!(
        "{:?}",
        match read_from_file_automatically(&get_filename("Enter filename: ")) {
            Ok(filestr) => filestr,
            Err(e) => format!("{:?}", e),
        }
    );
}

fn read_from_file_manually(filename: &str) -> Result<String, io::Error> {
    let file = File::open(filename);

    let mut f = match file {
        Ok(f) => f,
        Err(e) => return Err(e),
    };
    let mut username = String::new();
    match f.read_to_string(&mut username) {
        Ok(_) => Ok(username),
        Err(e) => Err(e),
    }
}

fn read_from_file_automatically(filename: &str) -> Result<String, io::Error> {
    let mut lines = String::new();
    File::open(filename)?.read_to_string(&mut lines)?;
    Ok(lines)
}

fn read_from_file_ultra_auto(filename: &str) -> Result<String, io::Error> {
    fs::read_to_string(filename)
}
