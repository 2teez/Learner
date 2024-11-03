#include "finder.h"

template <typename T>
std::size_t counter_if(T* start, T* stop, predicate p) {
    std::size_t counter {0};
    for (auto i = start; i < stop; ++i) {
        if (p(*i)) {
            counter++;
        }
    }
    return counter;
}
