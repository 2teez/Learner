#!/usr/bin/env bash

x=3
y=6
echo $(( $x + $y )) 
echo $(( $x - $y )) 
echo "scale=5; $(( $x / $y ))" | bc
echo $(( $x * $y )) 
