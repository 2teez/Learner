#!/usr/bin/env bash
## make directory and change to it
## directory is given as parameter

case $# in
    1);;
    *) printf "Usage: ./dm.sh <directory name>" >&2
       exit 1
esac

dir=$1 
if ! [[ -x $dir ]]
then
   echo "Will you want to use a name different from" \
" the one typed initially? [y|n]"
    read -r ans
    case $ans in 
        *[yY]*)
            echo "Enter a directory name."
            read -r dir
            # make the directory and with new name change to the directory
	    mkdir $dir && cd $dir
	    ;;
        *)
        # make the directory and change to the directory
	mkdir $dir && cd $dir
	;;
    esac
else
    echo "$dir exist."
    cd $dir
fi

exit 0
