#!/usr/bin/env bash
#
# Description: 
# Write a script that asks the user to enter a number between 20
# and 30. If the user enters an invalid number or a non-number, ask
# again. Repeat until a satisfactory number is entered.

echo -n "Enter a number between 20 and 30: "
read -r num
case $num in 
    *[0-9][0-9]*)
        while [[ $num -lt 20 || $num -gt 30 ]]; do
	    echo "Number MUST between 20 and 30"
	    echo -n "Enter a number between 20 and 30: "
	    read -r num
	done
	;;
    *) 
	echo "Use only numbers."
	exit 1
	;;
esac
printf "Number enter is %d\n" $num

exit 0
