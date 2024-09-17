#!/usr/bin/env python3

import random


def get_user_input(msg: str) -> str:
    """get input from user"""
    result = input(msg)
    return result


def get_random_number(a: int, b: int) -> int:
    return random.randint(a, b)
