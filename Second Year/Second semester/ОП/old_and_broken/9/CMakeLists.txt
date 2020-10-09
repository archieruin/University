cmake_minimum_required(VERSION 3.16)
project(9)

set(CMAKE_CXX_STANDARD 14)

include_directories(.)

add_executable(9
        distance.cpp
        distance.h
        main.cpp)
