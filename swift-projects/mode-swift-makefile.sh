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
    exit 1
fi

file="${1##*/}"
filename="${file%.*}"
file_extension="${file##*.}"

case "$file_extension" in
    swift)
        echo "$filename:" > makefile
        printf "\tswiftc ${1} -o $filename\n" >> makefile
        printf "\nclean:" >> makefile
        printf "\n\trm -rf ${filename%.*}" >> makefile
        ;;
    cpp|c)
        echo -n "what cpp standard?: "
        _std=
        while read -r line; do
            if ! [[ $line -eq 98 ||
            $line -eq 11 ||
            $line -eq 14 ||
            $line -eq 17 || $line -eq 23 ]]; then
                echo "Invalid option.. use any of these 98, 11, 14, 17, 23"
                echo -n "what cpp standard?: "
                continue
            else
                _std="$line"
                break
            fi
        done
        echo "${filename}:  ${filename}.o" > makefile
        printf "\tg++ ${filename}.o -o ${filename}\n" >> makefile
        echo "${filename}.o: ${file}" >> makefile
        printf "\tg++ -Wall -std=c++$_std -c ${file}\n\n" >> makefile
        echo "clean:" >> makefile
        printf "\trm -rf ${filename}.o ${filename}\n" >> makefile
        exit 0;;
    *)  echo "can only use this makefile for swift programming language."
        exit 1;;
esac

exit 0
