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
    if (index < 0 || index > 1)
        throw std::runtime_error("invalid index");
    if (index == 0) return (void*)&first;
    else return (void*)&second;
}

template<typename T, typename V>
std::ostream& operator<<(std::ostream& os, const Pair<T, V>& pair) {
    os << "Pair <first: " << pair.get_value_at0() <<
    ", second: " << pair.get_value_at1() << ">" << std::endl;
    return os;
}
