#!/usr/bin/env bash
# Author: omitida
# Date: 2024/11/02
# Description: Generating cmakefiles either
# from the file or a directory specified.
#
function Usage() {
    file=${0##*/}
    echo "${file%%*.}" "<filename> or <directory>"
}

if [[ ${#} -eq 0 ]]; then
   Usage
fi

filename="$1"
extension="${1##*.}"

# if the cli argument is a directory and is not empty
if [[ -d "$filename" ]] && ! [[ -s "$filename" ]]; then
   # move all the files to a sub-directory named src
   mv "$filename/*" "$filename/src/"
   #  then create a file named CMakeLists.txt
   touch "$filename/CMakeLists.txt"
# if the cli argument is a directory and is empty
elif [[ -d "$filename" && -s "$filename" ]]; then
   #  then create a file named CMakeLists.txt
       touch "$filename/CMakeLists.txt"
   #  make an empty sub-directory named src
       mkdir "$filename/src"
# if the cli argument is a cpp file
elif [[ -f "$filename" && "$extension" == "cpp" ]]; then
   basename="${filename%%.*}" # strip the file extension off
   mkdir -p "${basename}/src" # make a directory with the file basename
   mv "$filename" "${basename}/src" # then move the filename into the directory
   touch "$basename/CMakeLists.txt" # make CMakeLists.txt file in the directory
fi

exit 0
