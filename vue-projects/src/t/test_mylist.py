#!/usr/bin/env python3

import pytest
from pyutil import MyList


@pytest.fixture()
def mylist():
    mylist = MyList([1, 2, 3, 4])
    return mylist


def test_mylist_head(mylist):
    expected = [1, 2, 3, 4][0]
    got = mylist.hd()
    print(expected, got)
    assert expected == got


def test_mylist_tail(mylist):
    expected = [1, 2, 3, 4][1:]
    got = mylist.tl()
    print(expected, got)
    assert expected == got


def test_mylist_last(mylist):
    expected = [1, 2, 3, 4][3]
    got = mylist.last()
    print(expected, got)
    assert expected == got


def test_mylist_len(mylist):
    assert len(mylist) == 4
