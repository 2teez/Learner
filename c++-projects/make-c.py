#!/usr/bin/env python3

# check if the file has extension cpp
def check_file_ext(filename, ext='.cpp'):
    if not ext.startswith('.'):
        ext = f'.{ext}'
    if filename.endswith(ext) or filename.endswith('.cc'):
        return filename
    return filename + ext


def generate_default_file(stream) -> str:
    """split the default string"""
    return '\n'.join(line.lstrip() for line in stream.splitlines())


# make a file
def make_file(filename):
    # dictionary with key for different languages
    file_starters = {
        'cpp': """
#include <iostream>
#include <cstddef>

int main(int argc, char** argv) {
    return 0;
}
""",
        'sh': '#!/usr/bin/env bash',
        'py': '#!/usr/bin/env python3',
        'txt': '',
        'pl': '#!/usr/bin/env perl',
        'h': """
        #ifndef _REPLACE_HEADER_
        #define _REPLACE_HEADER_
        #endif //_REPLACE_HEADER_
        """,
    }
    # get the file extension to write the file started code
    _, ext = filename.split('.')
    with open(filename, 'w') as file:
        file.writelines(generate_default_file(file_starters[ext]))
        print('Done')


def main(file, dir='.', ext='.cpp'):
    import pathlib
    import sys
    import os

    dir = pathlib.Path(dir)
    if not dir.exists():
        # create the directory and make the file
        os.makedirs(dir)
        os.chdir(dir)
        make_file(check_file_ext(file, ext))
        sys.exit()
    else:
        file = check_file_ext(file, ext)
        if file in [file.name for file in dir.iterdir()]:
            print(f'{file} already exist. Make another one.')
            sys.exit()
        else:
            os.chdir(dir)
            make_file(file)
            sys.exit()


if __name__ == '__main__':
    """run main function"""
    import sys

    args = sys.argv
    if len(args) < 2 or len(args) > 4:
        print('Usage: ./make-c <filename-name> [directory] [file extension]')
        sys.exit()
    _, *opts = args

    main(*opts)
