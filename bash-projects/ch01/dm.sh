#!/usr/bin/env bash
## make directory and change to it
## directory is given as parameter

dir=$1 
if ! [[ -x $dir ]]
then
    echo "Enter a directory name."
    read -r dir
else
    echo "$dir exist."
    cd $dir
    exit 0
fi

# make the directory and change to the directory
mkdir $dir && cd $dir

exit 0
