#!/usr/bin/env bash
#author: omitida
#description: create and clean csharp files

function help() {
    echo "Usage: ./$(basename $0) -h | -b|-c|-r|-n|-s|-m <filename>"
    echo "options:"
    echo "-b    build and run project name"
    echo "-c    create project name"
    echo "-r    remove project bin folder"
    echo "-n    remove the entire project folder"
    echo "-h    display the help function"
    echo "-s    run a c# script. The script can have either .csx or .cs file extension."
    echo "-m    manually compiling and running a c# standalone file"
}

if [[ $# -ne 2 ]]; then
    help
    exit 1
fi

options="c:r:n:b:s:m:"
while getopts ${options} opt; do
    case $opt in
        b) if [[ -e "${OPTARG}" ]]; then
               cd "${OPTARG}"
               dotnet run
            elif [[ $(basename "${file}") == "${OPTARG}" ]]; then
                dotnet run
            fi
            ;;
        c)
            echo "Creating csharp project namely: ${OPTARG}"
            dotnet new console -n "${OPTARG}"
            dotnet build "${OPTARG}"
            ;;
        r)
            directory1=$(dirname "$OPTARG/bin")
            directory2=$(dirname "$OPTARG/obj")
            file1=$(basename "$OPTARG/bin")
            file2=$(basename "$OPTARG/obj")
            filefound1=$(ls -r "${directory1}" | grep "${file1}")
            filefound2=$(ls -r "${directory2}" | grep "${file2}")
            if [[ -z "$filefound1" ]] && [[ -z "$filefound2" ]];then
                echo "Neither \"$OPTARG/bin\" nor \"$OPTARG/obj\" folders were found." && exit 0
            fi
            echo "Deleted csharp project namely: ${OPTARG}/bin && ${OPTARG}/obj"
            rm -rf "${OPTARG}/bin"
            rm -rf "${OPTARG}/obj"
            ;;
        n)
            filefound=$(ls | grep "$OPTARG")
            if [[ -z "$filefound" ]];then
                echo "No \"$OPTARG\" project was found." && exit 0
            fi
            echo "Deleting csharp project namely: ${OPTARG}"
            echo -n "Do you want to delete the whole project file \"${OPTARG}\"? [y|n]: "
            while read -r line; do
                if [[ "${line,,}" == 'y' ]]; then
                    rm -rf "${OPTARG}"
                    exit 0
                else exit 0
                fi
            done
            ;;
        s)  # compiling and runing c# script
            dotnet-script "${OPTARG}"
            ;;
        m)  # compile and generate executable file
            csc "${OPTARG}" && mono "${OPTARG%.*}.exe"
            # remove the executable file after running it
            rm -rf "${OPTARG%.*}.exe";;
        h) help && exit1;;
        *) help && exit1;;
    esac
done

exit 0
