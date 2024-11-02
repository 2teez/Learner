cmake_minimum_required(VERSION 3.15)
# change the project name to name of choice
project(Myapp)
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
add_executable(Myapp src/howdy.cpp src/printer.cpp src/printer.h)
