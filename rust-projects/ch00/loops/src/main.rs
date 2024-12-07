fn main() {
    let mut count = 0;
    loop {
        count += 1;
        if count == 10 {
            break;
        }
    }
    println!("Count : {count}");
    // using a while loop
    let arr = [10, 20, 30, 40, 50];
    let mut index = 0;
    while index < 5 {
        println!("{} -> {:#?}", index + 1, arr[index]);
        index += 1;
    }

    // using for loop
    for elem in arr {
        println!("{}", elem);
    }
}
