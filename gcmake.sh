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
cmakelists_file=
# if the cli argument is a directory and is not empty
if [[ -d "$filename" ]] && ! [[ -s "$filename" ]]; then
   # move all the files to a sub-directory named src
   mkdir -p "${filename}/src"
   mv $filename/*.* "${filename}/src"
   #  then create a file named CMakeLists.txt
   cmakelists_file="${filename}/CMakeLists.txt"
   touch "${cmakelists_file}"
# if the cli argument is a directory and is empty
elif [[ -d "$filename" && -s "$filename" ]]; then
   #  then create a file named CMakeLists.txt
    cmakelists_file="${filename}/CMakeLists.txt"
    touch "${cmakelists_file}"
   #  make an empty sub-directory named src
    mkdir "${filename}/src"
# if the cli argument is a cpp file
elif [[ -f "$filename" && "$extension" == "cpp" ]]; then
   basename="${filename%%.*}" # strip the file extension off
   mkdir -p "${basename}/src" # make a directory with the file basename
   mv "$filename" "${basename}/src" # then move the filename into the directory
   cmakelists_file="${basename}/CMakeLists.txt"
   touch "${cmakelists_file}" # make CMakeLists.txt file in the directory
fi

echo "
cmake_minimum_required(VERSION 3.15)
# change the project name to name of choice
project(Myapp)
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
add_executable(Myapp ${filename})
" > "${cmakelists_file}"

exit 0
