#!/bin/bash

# Author: 2teez
# Date: 04/09/2024
# Modified: 04/09/2024
#
# Description:
# To back up the files in owner home directory
#
# Usage:
# ./backup_script

echo "Hello, ${USER^}"
echo "I will now back up your home directory, $HOME"

currentdir=$PWD
echo "You are running this script from $currentdir"
echo "Therefore, I will save the backup $currentdir"

tar -cf ./backup_"$(date +%d-%m-%Y_%H-%M-%S)".tar $HOME 2>/dev/null

echo "Backup Completed Successfully."
exit 0

