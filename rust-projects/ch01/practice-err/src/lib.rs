use std::io;

pub fn get_filename(msg: &str) -> String {
    print!("{}", msg);
    let mut line = String::new();
    io::stdin()
        .read_line(&mut line)
        .expect("Failure to read line");
    format!("{}", line.trim())
}
