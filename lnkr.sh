#!/usr/bin/env bash

# author: omitida
# date: 2024/12/03
# description: script to link a file to another directory
#
if [[ "$#" != 2 ]]; then
    filename=$(basename "$0")
    echo "Usage: $filename <file-to-link> <directory-to-link-file-to>"
    exit 1
fi

file_to_link=$(readlink -f "${1}")
link_to_directory=$(readlink -f "${2}")


if [[ -z "$file_to_link" ]]; then
   echo "file to link: $1 doesn't exist."
   exit 1;
elif ! [[ -d "$link_to_directory" ]]; then
    echo "Is either $2 is not a DIRECTORY or it doesn't exist."
    echo "To continue, you have to create the target directory: $2"
    printf "Yes -> continue, No to abort!: "
    while read -r answer; do
        [[ "$answer" == "yes" ]] && break;
        [[ "$answer" == "no" ]] && exit 1;
    done
    mkdir -pv "$2"
    link_to_directory=$(readlink -f "${2}")
fi

# check if the link already exists in target directory
file=$(basename "$file_to_link")
if [[ -L "$link_to_directory/$file" ]]; then
    echo "Warning: Link '$link_to_directory/$file' already exists."
    ex
fi

#link the file as the user wanted
ln -s "$file_to_link" "$link_to_directory/$file"
echo "Created: $link_to_directory/$file @ $(date)"

exit 0
