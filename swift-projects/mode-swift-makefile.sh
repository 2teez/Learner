#!/usr/bin/env bash
# author: omitida
# date: 2024/10/29
# Description:
# using makefile to compile and run swift file
# might make it a generic make-makefile later
#

# check if the a file is supplied
if [[ "${#}" -eq 0 ]]; then
    echo "Usage: $0 <filename.swift>"
fi

filename=${1##*/}
file_extension="${filename:${#filename},-5}"

case "$file_extension" in
    swift)
        filename="${filename%.*}"
        echo "$filename:" > makefile
        printf "\tswiftc ${1} -o $filename\n" >> makefile
        printf "\nclean:" >> makefile
        printf "\n\trm -rf ${filename%.*}" >> makefile
        ;;
    *)  echo "can only use this makefile for swift programming language."
        exit 1;;
esac

exit 0
