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

tar -cvf ./backup_"$(date +%d-%m-%Y_%H-%M-%S)".tar ./* 2>/dev/null
