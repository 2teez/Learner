#!/usr/bin/env python3

from money import Money


def main():
    """main function"""

    m1, m2 = Money(3, 5), Money(5, 89)
    print(m2, m1)
    print(m2 + m1)
    print(m1 - m2)


if __name__ == '__main__':
    main()
