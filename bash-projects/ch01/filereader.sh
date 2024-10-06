#!/usr/bin/env bash

case $# in 
    0)
        echo "Usage: $0 <filename>"
        echo -e "No filename provided.\nProvide a valid filename: "
        read -r filename
        while ! [[ -x $filename ]]; do
            echo -n "Enter a valid filename: "
            read -r filename
        done
        # read the file
        while IFS=  read -r line
        do
            echo $line
        done < ${filename}
        ;;
    1)
        filename=$1
        if ! [[ -x $filename ]]; then
            echo -n "Enter a valid filename: "
            read -r filename
            while ! [[ -x $filename ]]
            do
               echo -n "Enter a valid filename: "
               read -r filename
            done
        fi
        # read the file
        while IFS= read -r line
        do
            echo $line
        done < ${filename}
        ;;
    *)
        echo "Not more than one file to read"
        exit 1
     ;;
esac

exit 0
