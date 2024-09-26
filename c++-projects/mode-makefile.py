#!/usr/bin/env python3

def main(*args):
    files = args[1:]
    print(files)

if __name__ == '__main__':
    import sys

    args = sys.argv
    if len(args) == 1:
        print(f"Usage: ./mode-makefile [cpp file(s)]")
        exit(-1)
    main(*args)
