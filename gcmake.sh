#!/usr/bin/env bash
# Author: omitida
# Date: 2024/11/02
# Description: Generating cmakefiles either
# from the file or a directory specified.
#
function Usage() {
    local file=$(basename "$0")
    echo "Usage: $file <filename|directory> [C++ standard] [CMake version]"
}

if [[ ${#} -eq 0 || ${#} -gt 3 ]]; then
   Usage
   exit 1
fi

filename="$1"
extension="${1##*.}"
cmakelists_file=

# check for the cpp standard, and cmake version
std="${2:-17}"
version="${3:-3.15}"

# if the cli argument is a directory
if [[ -d "$filename" ]]; then
    #  make an empty sub-directory named src
    mkdir "${filename}/src"
    mv "${filename}"/*.* "${filename}/src" 2>/dev/null
   #  then create a file named CMakeLists.txt
    cmakelists_file="${filename}/CMakeLists.txt"
    touch "${cmakelists_file}"
# if the cli argument is a cpp file
elif [[ -f "$filename" && "$extension" == "cpp" ]]; then
   basename="${filename%%.*}" # strip the file extension off
   mkdir -p "${basename}/src" # make a directory with the file basename
   mv "$filename" "${basename}/src" # then move the filename into the directory
   cmakelists_file="${basename}/CMakeLists.txt"
   touch "${cmakelists_file}" # make CMakeLists.txt file in the directory
else
    echo "Error: Unsupported file type."
    exit 1
fi

cat << EOF > "${cmakelists_file}"
cmake_minimum_required(VERSION ${version})
# change the project name to name of choice
project(Myapp)
set(CMAKE_CXX_STANDARD ${std})
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_EXTENSIONS OFF)
add_executable(Myapp src/${filename})
EOF

echo "CMakeLists.txt generated at $cmakelists_file"
exit 0
