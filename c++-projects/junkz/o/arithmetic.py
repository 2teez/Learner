#!/usr/bin/env python3


def addition(*args) -> int:
    result = 0
    for value in args:
        result += value
    return result


def subtraction(*args) -> int:
    result = args[0]
    for value in args[1:]:
        result -= value
    return result


def multiplication(*args) -> int:
    result = args[0]
    for value in args[1:]:
        result *= value
    return result


def division(*args) -> float:
    result = args[0]
    for value in args[1:]:
        result /= value
    return result
