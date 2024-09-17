#!/usr/bin/env python3

# get all the functions in the arithmetic module
from arithmetic import *


class Arith:
    # map to create a data structure that has
    # math sign as keys, and each key has
    # corresponding maths function and function name
    math_sign = {
        '+': [addition, 'addition'],
        '-': [subtraction, 'subtraction'],
        '/': [division, 'division'],
        '*': [multiplication, 'multiplication'],
    }

    def __init__(self, *args,**sign):
        # class instance
        self.__args = args
        self.__sign = sign['sign']

    def do(self, sign) -> str:
        # change the operation if not the same with
        # the initial one given from the class instance
        # get the what arithmetic operation you are doing
        result = self.math_sign[self.__sign][1]

        if sign != result:
            self.__sign = self.math_sign[sign][0]
            result = self.math_sign[sign][1]

        return result.upper()

    def solve(self):
        # calls the class map sign to solve the question
        return self.math_sign[self.__sign][0](*self.__args)
