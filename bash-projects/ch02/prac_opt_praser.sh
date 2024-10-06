#!/usr/bin/env bash

filename=
optstring=f:mw
while getopts $optstring opt
do
    case $opt in
        f) filename=${0##*/}
           if [[ -n $filename ]]; then
               while IFS="\n" read -r line; do
                   echo $line
                done < $filename
            fi
        ;;
        m) echo "I am a man";;
        w) echo "a woman";;
        *) echo "Not covered."
           exit 1;;
    esac
done

echo "filename is $filename"
