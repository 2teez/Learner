pub fn largest(nums: &[i32]) -> &i32 {
    let mut result = &nums[0];
    for number in nums {
        if number > result {
            result = number;
        }
    }
    result
}

pub fn largest_g<T: std::cmp::PartialOrd>(data: &[T]) -> &T {
    let mut result = &data[0];
    for value in data {
        if value > result {
            result = value;
        }
    }
    result
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn find_greater_number() {
        let nums = [vec![4, 9, 2, 43, 5, 21], [-56, -8, 0, -13].to_vec()];
        let expected = [43, 0];
        for index in 0..expected.len() {
            assert_eq!(*largest(&nums[index]), expected[index]);
        }
    }

    #[test]
    fn find_greater_number_array() {
        let nums = [-56, -8, 0, -13];
        assert_eq!(*largest(&nums), 0);
    }

    #[test]
    fn find_greater_value_char() {
        let data = "aeiou".chars().collect::<Vec<_>>();
        assert_eq!(*largest_g(&data), 'u');
    }

    #[test]
    fn find_greater_numbers() {
        let nums = [vec![4, 9, 2, 43, 5, 21], [-56, -8, 0, -13].to_vec()];
        let expected = [43, 0];
        for index in 0..expected.len() {
            assert_eq!(*largest_g(&nums[index]), expected[index]);
        }
    }
}
