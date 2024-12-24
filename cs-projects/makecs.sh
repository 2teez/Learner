#!/usr/bin/env bash
#author: omitida
#description: create and clean csharp files

function help() {
    echo "Usage: ./$(basename $0) -h | -c|-r|-n <filename>"
    echo "options:"
    echo "-c    create project name"
    echo "-r    remove project bin folder"
    echo "-n    remove the entire project folder"
    echo "-h    display the help function"
}

if [[ $# -ne 2 ]]; then
    help
    exit 1
fi

options="c:r:n:"
while getopts ${options} opt; do
    case $opt in
        c)
            echo "Creating csharp project namely: ${OPTARG}"
            dotnet new console -n "${OPTARG}"
            dotnet build "${OPTARG}"
            ;;
        r)
            directory=$(dirname "$OPTARG/bin")
            file=$(basename "$OPTARG/bin")
            filefound=$(ls -r "${directory}" | grep "${file}")
            if [[ -z "$filefound" ]];then
                echo "No \"$OPTARG\" project was found." && exit 0
            fi
            echo "Deleted csharp project namely: ${OPTARG}/bin"
            rm -rf "${OPTARG}/bin"
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
        *) echo "wrong option $opt used. Use on -c or -cl"
            exit 1;;
    esac
done

exit 0
