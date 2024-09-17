#!/usr/bin/env python3

from typing import List


class MyList(List):
    """list class with two methods namely:
    `hd`, `tl`, last. Where hd is Head and tl is tail"""

    def __init__(self, lst):
        super().__init__()
        self.__counter = 0
        self.__lst = lst

    def __repr__(self) -> str:
        return super().__repr__()

    def hd(self):
        """get the first element in a non empty list"""
        head = None
        if len(self.__lst) == 0:
            raise Exception('Empty List')
        else:
            # get the head
            head = self.__lst[self.__counter]
            self.__counter = self.__counter + 1
            # self.__lst = self.__lst[self.__counter:]
        return head

    def tl(self):
        """get all the other element(s) in a non empty list"""
        tail = None
        if len(self.__lst) == 0:
            raise Exception('Empty List')
        if self.__lst != []:
            if len(self.__lst) == 1:
                tail = self.__lst[self.__counter]
            else:
                tail = self.__lst[self.__counter + 1 : len(self.__lst)]
        return tail

    def last(self):
        """get the last element in a non empty list"""
        if len(self.__lst) == 0:
            raise Exception('Empty List')
        else:
            return self.__lst[len(self.__lst) - 1]

    def __len__(self) -> int:
        return len(self.__lst) - self.__counter

    def is_empty(self) -> bool:
        if self.__len__() == 0:
            return True
        return False
