#!/usr/bin/env bash

function selected_tech() {
    echo "Which of the following do you want to use for your Web Development?"
    echo "1) ASP.NET MVC"
    echo "2) ASP.NET Core MVC/Razor"
    echo "3) ASP.NET Core WebApi"
    echo "e - To Exit."
    echo -n "Enter: "
}

echo "You are generating (\"scaffolding\") Web Project, using .NET Platform."
echo -n "Will you want to continue or no? [c|n]: "
while read -r line; do
   if [[ "${line,,}" == 'n' ]]; then
       echo "bye..bye.."
       echo "run \"./makec.sh\" again if you want."
       exit 0;
    elif [[ "${line,,}" = 'c' ]]; then
        selected_tech
        while read -r select; do
            case ${select} in
                1)  # making mvc using dotnet platform
                    dotnet new mvc -o "$1"
                    exit 0
                ;;
                2)  # making webapp using dotnet platform
                    dotnet new webapp -o "$1"
                    exit 0
                ;;
                3)  # making webapi using dotnet platform
                    dotnet new webapi -o "$1"
                    exit 0
                ;;
                e) exit 1;;
                *)
                    echo "${select} - Invalid option. Use only 1, 2 and 3 OR e to Exit."
                    selected_tech
                    continue
               ;;
            esac
        done
        break # exit the while loo
    else
        echo "\"${line}\" - Invalid response. Enter either 'c' or 'n'."
        echo -n "Will you want to continue or no? [c|n]: "
        continue
    fi
done
