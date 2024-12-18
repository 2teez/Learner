use practice_err::get_filename;
use std::fs::File;
use std::io::ErrorKind;

fn main() {
    // using match on Err
    File::open(get_filename("Enter filename: ")).unwrap_or_else(|error| {
        if error.kind() == ErrorKind::NotFound {
            File::create("m_log.txt").unwrap_or_else(|err| {
                panic!("{:?}", err);
            })
        } else {
            panic!("{:?}", error);
        }
    });
}
