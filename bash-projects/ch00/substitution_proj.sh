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

echo "${USER^}"
echo "I will now back up your home directory, $HOME"

tar -cvf ./backup_"$(date +%d-%m-%Y_%H-%M-%S)".tar $HOME 2>/dev/null
