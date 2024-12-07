#![allow(dead_code)]

fn main() {
    let arr = [0, 1, 2, 3, 4, 5, 6, 7, 12];
    for num in arr.iter().rev() {
        println!("Fibonacci number of {} is {}", num, fibo(*num));
    }

    for num in arr {
        println!("Fibonacci number of {} is {}", num, fibo_trad(num));
    }
}

fn fibo_trad(num: u32) -> u32 {
    if num == 0 {
        0u32
    } else if num <= 2 {
        1u32
    } else {
        fibo_trad(num - 1u32) + fibo_trad(num - 2u32)
    }
}

fn fibo(num: u32) -> u32 {
    use std::mem::swap;

    let (mut x, mut y) = (0u32, 1u32);
    if num == 0 {
        return x;
    }
    let mut count = 0;
    while count < num {
        //(x, y) = (y, y + x); // or
        //println!("Before Swap: x:{}, y:{}", x, y);
        swap(&mut x, &mut y);
        //println!("After Swap: x:{}, y:{}", x, y);
        y += x;
        count += 1;
    }
    x
}
