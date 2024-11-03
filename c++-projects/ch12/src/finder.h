
#ifndef _REPLACE_HEADER_
#define _REPLACE_HEADER_

#include <cstdlib>

typedef bool(*predicate)(int);

template <typename T>
std::size_t counter_if(T*, T*, predicate);

#endif //_REPLACE_HEADER_
