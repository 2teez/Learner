#!/usr/bin/env bash

program="${0}"
if [[ "${#}" -lt 2 || "${#}" -gt 4 ]]
then
  printf "Usage: %s <filename> <directory> <extension>\n" "$program"
  exit 1
fi

filename="${1}"
directory="${2}"
extension="${3}"

function check_file_extension() {
    case "$filename" in
       *[.]*) filename="$filename";;
       *) filename="${filename}.$extension"
          ;;
    esac
}

function generate_file() {
    check_file_extension "$filename"
    case "$filename" in
      *.java*) echo "
      \r//package com.practice.program;
      \rimport static java.lang.System.out;
      \rclass Program {
          \r\tpublic static void main(String[] args) {

              \r\tout.println("Hello, World");
          \r\t}
      \r}
      ";;
      *.cpp*) echo "
      #\rinclude <iostream>
      #\rinclude <cstddef>

      \rint main(int argc, char** argv) {

            \r\treturn 0;
      \r}";;
      *.sh*) echo "\r#!/usr/bin/env bash";;
      *.py*) echo "\r#!/usr/bin/env python3";;
      *.txt*) echo "";;
      *.pl*) echo "\r#!/usr/bin/env perl";;
      *.h*) echo "
      #\rifndef _REPLACE_HEADER_
      #\rdefine _REPLACE_HEADER_
      #\rendif //_REPLACE_HEADER_
      ";;
      *) echo "";;
    esac
}

function file_checker() {
  # check to find the file in the directory
  # check if the directory doesn't exist
  if ! [[ -x "$directory" ]]
  then
    echo "$directory doesn't exit."
    echo "$directory would be created."
    return
  else
    ls "$directory" | while read -r file
      do
        if [[ "${filename}.$extension" == "$file" ]]; then
            echo "$file exists.";
            exit 1
        fi
      done
  fi
}

file_checker  # file checker in a specified directory

case "$directory" in
    *.*)  generate_file > "${filename}.$extension";;
    *) mkdir -p "$directory"
       cd "$directory"
       generate_file > "${filename}.$extension";;
esac
