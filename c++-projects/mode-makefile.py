#!/usr/bin/env python3
def remove_extensions(file):
    return file.split('.')[0]

def write_makefile(files):
    # write out make file for a single file
    filename = 'makefile'
    with open(filename, 'w') as file:
        if len(files) == 1:
            cfile = remove_extensions(files[0])
            ofile = cfile+'.o'
            print(f"{cfile}:\t{ofile} \
                \r\tg++ {ofile} -o {cfile}\n\
                \r{ofile}:\t{files[0]} \
                \r\tg++ -Wall -std=c++17 -c {files[0]} \
                \rclean: \
                \r\trm -rf ofile cfile", file=file)

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
