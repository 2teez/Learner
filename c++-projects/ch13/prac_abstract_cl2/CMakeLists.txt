cmake_minimum_required(VERSION 3.15)
# change the project name to name of choice
project(Myapp)
set(CMAKE_CXX_STANDARD 23)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_EXTENSIONS OFF)
add_executable(Myapp src/main.cpp src/transport.cpp src/transport.h
src/car.cpp src/bicycle.cpp src/routeplanner.cpp src/routestrategy.cpp src/routestrategy.h)
