#![allow(dead_code)]

fn main() {
    const DAYS_OF_CHRISTMAS: [&str; 12] = [
        "first", "second", "third", "forth", "fifth", "sixth", "seventh", "eighth", "ninth",
        "tenth", "eleventh", "twelveth",
    ];
    for day in DAYS_OF_CHRISTMAS {
        println!("{}", christmas_song(day));
    }
}

fn christmas_song(day: &str) -> String {
    format!(
        "On the {} day of christmas my true love said to me \n{}",
        day,
        match day {
            "first" => get_lyrics(0, 1),
            "second" => get_lyrics(0, 2),
            "third" => get_lyrics(0, 3),
            "fourth" => get_lyrics(0, 4),
            "fifth" => get_lyrics(0, 5),
            "sixth" => get_lyrics(0, 6),
            "seventh" => get_lyrics(0, 7),
            "eighth" => get_lyrics(0, 8),
            "ninth" => get_lyrics(0, 9),
            "tenth" => get_lyrics(0, 10),
            "eleventh" => get_lyrics(0, 11),
            "twelveth" => get_lyrics(0, 12),
            _ => "".to_string(),
        },
    )
}

fn get_lyrics(start: usize, stop: usize) -> String {
    const LYRICS: [&str; 12] = [
        "A partridge in a pear tree",
        "Two turtle doves and",
        "Three french hens",
        "Four calling birds",
        "Five golden rings",
        "Six geese a-laying",
        "Seven swans a-swimming",
        "Eight maids a-milking",
        "Nine ladies dancing",
        "Ten lords a-leaping",
        "Eleven pipers piping",
        "Twelve drummers drumming",
    ];
    let mut str = String::new();
    for index in (start..stop).rev() {
        str += &(format!("{}\n", LYRICS[index]));
    }
    str.to_string()
}
