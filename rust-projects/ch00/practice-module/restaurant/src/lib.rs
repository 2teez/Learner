mod front_house {
    pub mod hosting {
        pub fn add_to_waitlist() {}
        fn seat_at_table() {}
    }

    mod serving {
        fn take_order() {}
        fn serve_order() {}
        fn take_payment() {}
    }
}

use crate::front_house::hosting;

pub fn eat_at_restaurant() {
    //crate::front_house::hosting::add_to_waitlist();
    hosting::add_to_waitlist();
    front_house::hosting::add_to_waitlist();
}
/*pub fn add(left: u64, right: u64) -> u64 {
    left + right
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn it_works() {
        let result = add(2, 2);
        assert_eq!(result, 4);
    }
}*/
