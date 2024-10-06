#!/usr/bin/env python3

import pathlib


def main(filename: str) -> None:
    """check if the file exist
    if it does read it"""
    file = pathlib.Path(filename)
    if file.is_file():
        with open(file) as f:
            for line in f.readlines():
                print(line.strip())
    else:
        print(f"{file} doesn't exist.")
        main(input('Enter a valid file: '))


if __name__ == '__main__':
    """call main function"""
    import sys

    filename = ''
    args = sys.argv
    if len(args) != 2:
        filename = input('Enter a filename: ')
    else:
        filename = args[1]

    main(filename=filename)
