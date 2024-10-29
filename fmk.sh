#!/usr/bin/env bash
# author: timothy adigun
# date: October 2024
# description:
# make file and dierctory for
# different programming languages

program="${0}"
if [[ "$#" == 1 ]]; then
  optstring="d:h"
  while getopts $optstring opt; do
    case "$opt" in
      d) filename="${OPTARG:1}"
         if  [[ -e "$filename" ]]; then
            echo "Deleting ...."
            [[ -d "$filename" ]] && rm -rf "$filename"
            [[ -f "$filename" ]] && rm "$filename"
         else
            echo "$filename doesn't exist"
         fi
        exit 0;;
      h) echo "Usage: ${program} -d=<filename|didrectory>"
         echo "Or"
         echo "Usage: ${program} <filename> <directory> <extension>"
      exit 0
      ;;
      ?) echo "Usage: ${program} -d=<filename|didrectory>"; exit 1;;
    esac
  done
elif [[ "$#" -lt 2 || "$#" -gt 4 ]]
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
//package com.practice.program;
import static java.lang.System.out;
class Program {
    public static void main(String[] args) {

        out.println(\"Hello, World\");
    }
}
      ";;
      *.cpp*) echo "
#include <iostream>
#include <cstddef>

int main(int argc, char** argv) {

    return 0;
}";;
      *.sh*) echo "#!/usr/bin/env bash";;
      *.py*) echo "#!/usr/bin/env python3";;
      *.txt*) echo "";;
      *.pl*) echo "#!/usr/bin/env perl";;
      *.h*) echo "
#ifndef _REPLACE_HEADER_
#define _REPLACE_HEADER_
#endif //_REPLACE_HEADER_
      ";;
      *.swift*) echo "import Foundation";;
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
    *) mkdir -pv "$directory"
       cd "$directory" || exit
       generate_file > "${filename}.$extension";;
esac
echo "Done."
exit 0
