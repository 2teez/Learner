#!/usr/bin/env python3

# Version: 0.1
# Description:
    # it takes a file with an extension `cod`
    # and parse the file line by line into a
    # cpp file.
    # You don't have to write any main function
    # for a cpp program file.
    # if a function is written. It will create the
    # function declaration and write out the main function.
    #
from typing import List

def write_main(lst: List[str], file):
    #
    print('int main(int argc, char** argv) {', file=file)
    previous_line = lst[0];

    for line in lst:
        if not line.startswith("#include") and not line.startswith("#"):
            print(line, file=file, end='')
    print('return 0;\n}', file=file, end='')

def get_header(lst: List[str], file):

    for line in lst:
        if line.startswith("#include"):
            print(line.strip(), file=file)
        elif line.startswith("#"):
            line = f"#include <{line[1:len(line)-1]}>"
            print(line.strip(), file=file)


def get_function_declarations(lst: List[str], file):
    previous_line = lst[0]

    for line in lst:
        if line == '{\n' and previous_line.endswith(')\n'):
            print(line, file=file)
            print(f"{previous_line.strip()};", file=file)
        previous_line = line

def read_file(filename: str) -> List[str]:
    file_list = []
    # read the file
    with open(filename) as file:
        for line in file.readlines():
            file_list.append(line)
    return file_list

def main(filename: str) -> None:

    lines = read_file(filename=filename) # read a file

    output_file = filename + '.cpp'
    # open a file out
    file = open(output_file, 'a')
    # parse file
    get_header(lines, file)
    get_function_declarations(lines, file)
    write_main(lines, file)



if __name__ == '__main__':
    # launch the main function
    import sys

    argv = sys.argv
    if len(argv) != 2:
        print(f'Usage: ./make-playg.py <filename.cod>')
        sys.exit(-1)
    if not argv[1].endswith('.cod'):
        print(f'{argv[1]} must be a file with an extension `.cod`')
        print(f'Usage: ./make-playg.py <filename.cod>')
        sys.exit(-1)

    filename = argv[1]
    main(filename=filename)
