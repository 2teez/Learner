#!/usr/bin/env python3

def ignore_line(lookup, file):
    import pathlib
    filepath = pathlib.Path(file)
    status = False
    with filepath.open() as file:
        for line in file.readlines():
            if lookup in line:
                status = True
                break
    if not status:
        return f"echo */*/{lookup} >> {file.name}"
    return ""

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
                \r\trm -rf {ofile} {cfile}", file=file)
        else:  # write for multiple files
            cfiles = [remove_extensions(file) for file in files]
            ofiles = [file+'.o' for file in cfiles]
            mofiles = ' '.join(ofiles)
            print(f"{cfiles[0]}:\t{mofiles} \
                \r\tg++ {mofiles} -o {cfiles[0]}\n\
                \r{ofiles[0]}:\t{files[0]} \
                \r\tg++ -Wall -std=c++17 -c {' '.join(files)} \
                \rignore: \
                \r\t{ignore_line(cfiles[0], '../../.gitignore')} \
                \rclean: \
                \r\trm -rf {mofiles} {cfiles[0]}", file=file)

def main(*args):
    import subprocess

    files = args[1:]
    write_makefile(files)

if __name__ == '__main__':
    import sys

    args = sys.argv
    if len(args) == 1:
        print(f"Usage: ./mode-makefile [cpp file(s)]")
        exit(-1)
    main(*args)
