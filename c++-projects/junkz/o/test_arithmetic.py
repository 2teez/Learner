#!/usr/bin/env python3

import pytest
from arith import Arith
from arithmetic import addition, subtraction, multiplication, division


def test_addition():
    """testing addition function"""
    assert (4 + 4 + 2) == addition(4, 4, 2)


def test_subtraction():
    """testing subtraction function"""
    got = {0: [[4, 4, 2], -2], 1: [[8, 2, 2, 4], 0]}
    for ind in range(2):
        assert got[ind][1] == subtraction(*got[ind][0])


def test_multiplication():
    """testing subtraction function"""
    got = {0: [[4, 4, 2], 32], 1: [[8, 2, 2, 4], 128]}
    for ind in range(2):
        assert got[ind][1] == multiplication(*got[ind][0])


def test_division():
    """testing subtraction function"""
    got = {0: [[4, 4, 2], 0.5], 1: [[8, 2, 2, 4], 0.5]}
    for ind in range(2):
        assert got[ind][1] == division(*got[ind][0])


@pytest.fixture()
def arith_class_in():
    # instance of arith class
    arith_class_in = Arith(*[3, 8, 5])
    return arith_class_in


def test_arith_addition(arith_class_in):
    # test the addition function of the class
    assert arith_class_in.solve() == 16
