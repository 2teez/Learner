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

function header() {
    local len="${#1}"
    local pad="$2"
    for (( n=0; n<"$len"; n++)); do
        printf "%s" "$pad"
    done
    printf "\n"
    printf "$1\n"
    for (( n=0; n<"$len"; n++)); do
        printf "%s" "$pad"
    done
    printf "\n"
}

current_branch_name=$(git branch | grep -i '*')
current_branch_name="${current_branch_name:2}"
n=1

# using options with gitter added 2028/10/28
option=":s"
while getopts ${option} opt; do
    case $opt in
        s)
            git status; exit 0;;
        *) echo "invalid options: $OPTARG - only -s option is allowed."
           exit 1;;
    esac
done

for name in $@;
do
    header "Adding $name to ${current_branch_name} repo..." '*'
    echo "Do you want to continue? [c|n]"
    # read line and make it small caps
    read -r line
    while [[ "${line,,}" != "c" ]]; do
	    if [[ $line == "n" ]]; then exit 0; fi
	    echo "Enter 'c' to continue: "
	    read -r line
    done
    git add "$name"

    header "To commit addition to the branch ${current_branch_name} repo...., Enter your comment." "*"
    read -r comment
    while [[ "${#comment}" -eq 0 ]];
    do
	    header "commit addition to the branch with valid input; Enter your comment.: " "*"
	    read -r comment
    done
    git commit -m "$comment"
    header "Pushing your local respository to online repository.. \n<Press Enter to finish..>" "*"
    read -r line
    git push
done

exit 0
