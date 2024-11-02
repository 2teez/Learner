#ifndef PRINTER_H
#define PRINTER_H

#include <iostream>
#include <initializer_list>

template <typename R=char, typename T>
void print(std::initializer_list<const T> = {}, const R='\n');

template <typename T>
void print(T...);

template <typename T=void>
inline void print(void) {
	std::cout << std::endl;
}

#endif  // PRINTER_H
