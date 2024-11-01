#!/usr/bin/env bash
# author: omitida
# date: 2024/10/18
# Description: Providing a quick git command of
# status -- git status
# adding -- git add
# commit -- git commit -m
# push   -- git push
# The use will only provide the name of the file(s) to gitter

function Usage() {
    echo "Usage: $0 <filenames> Or use $0 -h"
    exit 1
}


function help_func() {
    echo "Usage:" "$0 <filename> | -s | -h | -U | -c <change to named branch>"
    echo
    echo "Options are as follows:"
    echo "-s	Displays the git status."
    echo "-h	Display the help and description of usage."
    echo "-U	<filename>"
    echo "	Update .gitignore file with the named file or document"
    echo "-c	<change to named branch>"
    echo "	This option takes value which is the name of a named branch. And it changes to the branch IF it exist."
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
option=":shU:c:"
while getopts ${option} opt; do
    case $opt in
        s)
            git status; exit 0;;
        c)
            # only y or Y (as y would be used as lowercase) would be true
            # every other option would be false
            echo -n "Change from ${current_branch_name} branch to ${OPTARG}? [y|n]: "
            while read -r answer; do
                if [[ "${answer,,}" == 'y' ]]; then
                    break # from the while loop to run git command
                else exit 0 # exit from this script all together
                fi
            done
            git checkout "$OPTARG"
            exit 0;;
	U)
	    cat ../../.gitignore |
		    while read -r line; do
			if [[ $OPTARG == $line ]]; then
				exit 0
			fi
		    done
	    echo "${OPTARG}" >> ../../.gitignore
	    exit 0;;
	h)
	   help_func; exit 1;;
        *) echo "invalid options: $OPTARG - only '-s' and '-c <branch-name>' option is allowed."
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
