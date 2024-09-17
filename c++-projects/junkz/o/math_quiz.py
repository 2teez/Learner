#!/usr/bin/env python3

import sys

# moddules used in this program imported
from arithmetic import addition, subtraction, multiplication, division
from user_api import get_user_input, get_random_number

# map to create a data structure that has
# math sign as keys, and each key has
# corresponding maths function and function name
math_sign = {
    '+': [addition, 'addition'],
    '-': [subtraction, 'subtraction'],
    '/': [division, 'division'],
    '*': [multiplication, 'multiplication'],
}


def main() -> None:
    """main entry function"""
    print('Welcome To Arithmetic Random Practice.')

    while True:
        print('Enter any of the below math operation:')
        sign = get_user_input('+, -, /, *: ')

        # check the user input as regards the sign to be tested
        # created a list by spliting a string and checking
        # user input in it
        while sign not in '+,-,/,*':
            print('Select any of the below math operation:')
            sign = get_user_input('+, -, /, *: ')
        print(f'You would be randomly tested on {math_sign[sign][1].upper()}')
        number_limit = 0
        try:
            number_limit = int(
                get_user_input('Enter the number range highest limit: ')
            )
        except:
            print('Enter an integer.')
            # call the main function and start over if error
            main()

        while True:
            # get the random numbers to use
            first_number = get_random_number(1, number_limit)
            second_number = get_random_number(1, number_limit)

            print(f'{first_number} {sign} {second_number} = ?')
            result = math_sign[sign][0](first_number, second_number)

            user_answer = get_user_input('[Q to Exit.] = ')
            # end the whole program if Q is given
            if user_answer.upper() == 'Q':
                sys.exit()
            # this "might" fail on float
            if int(user_answer) != result:
                print(f'\a {user_answer}. Wrong!')
                print(f'Right answer is {result}')


if __name__ == '__main__':
    """call main function as entry for the program"""
    main()
