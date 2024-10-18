#!/usr/bin/env bash

set -e

statement="A quick dog jump over a lazy fox"
statement2="truth is truth, no ajustment or balance."
statement3="You can't balance the truth."

function surrounded() {
    local len="${#1}"
    local pad="$2"
    for (( n=0; n<"$len"; n++)); do
        printf "%s" "$pad"
    done
    printf "\n"
    printf "| $1 |\n"
    for (( n=0; n<"$len"; n++)); do
        printf "%s" "$pad"
    done
    printf "\n"
}

for value in "$statement" "$statement2"; do
  surrounded "$value" '-'
  done

exit 0
