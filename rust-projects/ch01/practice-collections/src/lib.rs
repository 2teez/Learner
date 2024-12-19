#![allow(dead_code)]

fn get_value<T: Clone>(v: &Vec<T>, index: usize) -> T {
    match v.get(index) {
        Some(value) => value.clone(),
        None => v[0].clone(),
    }
}

fn make_vecs(ar: &[u32]) -> Vec<u32> {
    let mut v = Vec::new();
    for elem in ar {
        v.push(*elem);
    }
    v
}

fn starts_with_vowel(wrd: &str) -> bool {
    for elem in "aeiou".chars() {
        let value = wrd.chars().nth(0).unwrap();
        if value == elem {
            return true;
        }
    }
    false
}

pub fn gets(msg: &str) -> String {
    use std::io;
    print!("{}", msg);
    let mut line = String::new();
    io::stdin()
        .read_line(&mut line)
        .expect("Failure to read line");
    format!("{}", line.trim())
}

pub fn pig_latin(wrd: &str) -> String {
    if starts_with_vowel(wrd) {
        return format!("{}-hay", wrd);
    }
    format!("{1}-{0}ay", &wrd[0..1], &wrd[1..wrd.len()])
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn vec_creaction() {
        let actual = make_vecs(&[2, 8, 23, 6, 0]);
        let expected = vec![2, 8, 23, 6, 0];
        assert_eq!(expected, actual);
    }

    #[test]
    fn vec_get_value() {
        let v = make_vecs(&[8, 3, 1, 7]);
        for index in 0..4 {
            assert_eq!(get_value(&v, index), *&v[index]);
        }
    }

    #[test]
    fn string_starts_with_vowels() {
        for wrd in ["erlang", "apple"] {
            assert_eq!(true, starts_with_vowel(wrd));
        }
    }

    #[test]
    fn check_string_on_pig_latin() {
        let expected = vec!["erlang-hay", "apple-hay", "lojure-cay", "ava-jay"];
        let mut count = 0;
        for wrd in ["erlang", "apple", "clojure", "java"] {
            assert_eq!(expected[count].to_owned(), pig_latin(wrd));
            count += 1;
        }
    }
}
