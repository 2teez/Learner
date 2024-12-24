#!/usr/bin/env bash
#author: omitida
#description: create and clean csharp files

function help() {
    echo "Usage: ./$(basename $0) -h | -b|-c|-r|-n <filename>"
    echo "options:"
    echo "-b    build and run project name"
    echo "-c    create project name"
    echo "-r    remove project bin folder"
    echo "-n    remove the entire project folder"
    echo "-h    display the help function"
}

if [[ $# -ne 2 ]]; then
    help
    exit 1
fi

options="c:r:n:b:"
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
            if [[ -z "$filefound1" ]] || [[ -z "$filefound2" ]];then
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
        h) help && exit1;;
        *) help && exit1;;
    esac
done

exit 0
