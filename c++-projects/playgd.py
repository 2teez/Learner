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

def write_main(lst: List[str]):
    #
    print('int main(int argc, char** argv)\n{')
    previous_line = lst[0];

    for line in lst:
        if not line.startswith("#include"):
            if line.endswith(')'):
                print('return 0;\n}')
            print(line.strip())


def get_header(lst: List[str]):
    for line in lst:
        if line.startswith("#include"):
            print(line.strip())

def get_function_declarations(lst: List[str]):
    previous_line = lst[0]

    for line in lst:
        if line == '{\n' and previous_line.endswith(')\n'):
            print(f"{previous_line.strip()};")
        previous_line = line

def read_file(filename: str) -> List[str]:
    file_list = []
    # read the file
    with open(filename) as file:
        for line in file.readlines():
            file_list.append(line)
    return file_list

def main(filename: str) -> None:
    # parse file
    get_header(read_file(filename=filename))
    get_function_declarations(read_file(filename=filename))
    write_main(read_file(filename=filename))



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
