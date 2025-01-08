#!/usr/bin/env bash
#author: omitida
#description: create and clean csharp files

function help() {
    echo "Usage: ./$(basename $0) -h | -b|-c|-r|-n|-s|-m|-l <filename>"
    echo "options:"
    echo "-b    build and run project name"
    echo "-c    create project name"
    echo "-r    remove project bin folder"
    echo "-n    remove the entire project folder"
    echo "-h    display the help function"
    echo "-s    run a c# script. The script can have either .csx or .cs file extension."
    echo "-m    manually compiling and running a c# standalone file"
    echo "-l    create a library project folder and link with the project to use it."
    echo "-w    create a web project namely: ASP.NET MVC, ASP.NET CORE MVC/Razor (webApp) OR WebAPI"
}

if [[ $# -ne 2 ]]; then
    help
    exit 1
fi

function remove_unwamted_folders(){
    target_folder="${1}"
    directory1=$(dirname "${target_folder}"/bin)
    directory2=$(dirname "${target_folder}/obj")
    file1=$(basename "$target_folder/bin")
    file2=$(basename "$target_folder/obj")
    filefound1=$(ls -r "${directory1}" | grep "${file1}")
    filefound2=$(ls -r "${directory2}" | grep "${file2}")
        if [[ -z "$filefound1" ]] && [[ -z "$filefound2" ]];then
            echo "Neither \"$OPTARG/bin\" nor \"$OPTARG/obj\" folders were found." && return
        fi
        echo "Deleted csharp project namely: ${target_folder}/bin && ${target_folder}/obj"
        rm -rf "${target_folder}/bin"
        rm -rf "${target_folder}/obj"
}

function lists_and_delete() {
    directory="${1}"
    echo "This check for bin and obj folders and delete them"
    echo -n "would you want to continue? [c|n]: "
    while read -r line; do
        case "${line,,}" in
           c)
             for file in "${directory}"/*; do
                if [[ -d "$file" ]]; then
                    remove_unwamted_folders "${file}"
               fi
              done
              break
            ;;
           n) echo "Bye.."
              exit 0
            ;;
           *) echo "\"${line}\" - Invalid option. Enter either c to continue or n to end."
            ;;
        esac
    done
}

options="c:r:n:b:s:m:l:w:"
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
            # call function list and delete
            echo "Are you deleting single project or multiple? "
            echo -n "m - Multiple | s - Single : "
            while read -r answer; do
                case "$answer" in
                m)
                lists_and_delete "${OPTARG}"
                break
                ;;
                s) remove_unwamted_folders "${OPTARG}"
                   break
                ;;
                *) echo "${answer} - Invalid input."
                   continue;;
                esac
            done
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
        l)  # create class library
            dotnet new classlib -n "${OPTARG}"
            echo -n "Enter the name of the Project to include the library: "
            while read -r line; do
                # find the project entered
                findproject=$(ls | grep "${line}")
                if [[ -z "${findproject}" ]]; then
                    echo "Run $(basename $0) -c ${line}"
                    echo "To create the project first then run this command to make a library."
                    rm -rf "${OPTARG}"
                    exit 1
                else
                    projdirectory="${line}"
                    cd "$projdirectory"
                    dotnet add reference ../"${OPTARG}"/"${OPTARG}.csproj"
                    exit 0;
                fi
            done
            ;;
        m)  # compile and generate executable file
            csc "${OPTARG}" && mono "${OPTARG%.*}.exe"
            # remove the executable file after running it
            rm -rf "${OPTARG%.*}.exe";;
        w) makecweb.sh "${OPTARG}" # call the script namely makecweb.sh
        ;;
        h) help && exit1;;
        *) help && exit1;;
    esac
done

exit 0
