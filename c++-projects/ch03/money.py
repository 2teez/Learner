#!/usr/bin/env python3

class Money:
    '''class declare money type'''
    def __init__(self, unit: int, fraction: float, name: str = 'Naira'):
        'initialize money class'
        self.__unit = unit
        self.__fraction = fraction
        self.__name = name.casefold()

    def get_name(self) -> str:
        'get the money name'
        return self.__name

    def get_unit(self) -> int:
        'get the money type unit'
        return self.__unit

    def get_fraction(self) -> float:
        'get money type fractional type'
        return self.__fraction

    def __str__(self) -> str:
        '''string repr of the money data type'''
        if self.__unit != 0:
            return f"{self.__unit}.{abs(self.__fraction)} {self.__name}"
        return self.__repr__()

    def __repr__(self) -> str:
        '''string repr for money type'''
        return f"{self.__unit}.{self.__fraction} {self.__name}"

    def __add__(self, m):
        '''add two same type of money'''
        if self.__eq__(m):
            return Money(self.__unit + m.__unit,
                self.__fraction + m.__fraction)
        return Exception("Can't add two different Money type")

    def __sub__(self, m):
        'minus type of money'
        #self, m = self.__sorter(m) # superflulious here
        if self.__same_type(m):
            return Money(self.__unit - m.get_unit(),
                self.__fraction - m.get_fraction())
        return Exception("Can't subtract two different Money type")

    def __eq__(self, m, /) -> bool:
        return self.__name == m.get_name()

    def __lt__(self, m):
        'implement less than'
        return ((self.__unit < m.get_unit()) and (self.__fraction < m.get_fraction()))

    def __gt__(self, m):
        'implement greater than'
        return ((self.__unit > m.get_unit()) and (self.__fraction > m.get_fraction()))

    def __sorter(self, m):
        'sort the type of money in descending order'
        if self > m:
            return self, m
        return m, self

    def __same_type(self, m) -> bool:
        'check type of Money'
        return self.__eq__(m)
