#include "prac_template.h"

template <typename T, typename V>
Pair<T, V>::Pair(T first_value, V second_value): first(first_value),
  second(second_value) {}

template <typename T, typename V>
Pair<T, V> Pair<T, V>::with(T first_value, V second_value) {
    return Pair<T, V>(first_value, second_value);
}

template <typename T, typename V>
T Pair<T, V>::get_value_at0() const {
    return first;
}


template <typename T, typename V>
V Pair<T, V>::get_value_at1() const {
    return second;
}

template <typename T, typename V>
void* Pair<T,V>::get_value_at(int index) const {
    if (index < 0 or index > 1)
        throw std::runtime_error("invalid index");
    return (index == 0 ? get_value_at0() : get_value_at1());
}
