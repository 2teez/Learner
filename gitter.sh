#!/usr/bin/env bash
# author: omitida 
# date: 2024/10/18
# Description: Providing a quick git command of
# adding -- git add
# commit -- git commit -m
# push   -- git push
# The use will only provide the name of the file(s) to gitter

function Usage() {
    echo "Usage: $0 <filenames>"
    exit 1
}


if [[ "$#" -eq 0 ]]; then
	Usage
fi

n=1
for name in $@;
do
    echo "Adding $name ..."
    git add "$name"

    echo "commit addition to the branch..."
    read -r comment
    while [[ "${#comment}" -eq 0 ]];
    do
	    echo "commit addition to the branch with valid input: "
	    read -r comment
    done
    git commit -m "$comment"
    echo "Pushing your local respository to online respository.."
    read -r line
    git push
done

exit 0
