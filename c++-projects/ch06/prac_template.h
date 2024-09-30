#ifndef _PRAC_TEMPLATE_H_
#define _PRAC_TEMPLATE_H_

#include <iostream>

template <typename T, typename V>
class Pair {
    public:
    Pair() = delete;
    Pair(T, V);
    Pair<T, V> with(T, V);
    T get_value_at0() const;
    V get_value_at1() const;
    void* get_value_at(int) const;
    private:
        T first;
        V second;
};

#endif //_PRAC_TEMPLATE_H_
