#!/usr/bin/env python3

import sys

# moddules used in this program imported
from arith import Arith as Arithmetic
from user_api import get_user_input, get_random_number


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
        print(f'You would be randomly tested on {Arithmetic.math_sign[sign][1].upper()}')
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
            ari = Arithmetic(first_number, second_number, sign=sign)
            result = ari.solve()

            user_answer = get_user_input('[Q to Exit.] = ')
            # end the whole program if Q is given
            if user_answer.upper() == 'Q':
                sys.exit()
            # check sign for division case?
            if sign == '/':
                user_answer = float(user_answer)
            else:
                user_answer = float(user_answer)
            if user_answer != result:
                print(f'\a {user_answer}. Wrong!')
                print(f'Right answer is {result}')


if __name__ == '__main__':
    """call main function as entry for the program"""
    main()
