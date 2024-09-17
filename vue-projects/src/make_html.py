#!/usr/bin/env python3
from pyutil import MyList


def get_html_file(f: str) -> str:
    '''read from html basic file located at the root
    of the project'''
    with open(f) as file:
        return ''.join(file.readlines())


def main(s: str, title='') -> None:
    """write basic html string on the file"""
    filename, _ = s.split('.')
    title = title or filename

    with open(s, 'w') as file:
        file.writelines(
            get_html_file('./basic_html').replace('{title}', title)
        )


if __name__ == '__main__':
    """call the main function"""
    import sys
    import pathlib

    args = sys.argv
    if len(args) == 1:
        print('Usage: ./make_html <filename>')
        sys.exit()
    _, *filename = args

    # use an improvised list to get the head (first element)
    # of a list. The list provide other functions like: is_empty function on list
    files = MyList(filename)
    filename = files.hd()

    # check the file exist
    if pathlib.Path(filename).exists() and filename.endswith('.html'):
        print(f'{filename} exists. Use another filename.')
        sys.exit()
    if not filename.endswith('.html'):
        filename += '.html'
    if files.is_empty():
        main(filename, '')
    else:
        main(filename, files.hd())
