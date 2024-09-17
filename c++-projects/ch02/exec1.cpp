#include <iostream>
#include <cstddef>
#include <vector>

int &get(int *array, int index) { return array[index];}
void recu_vec_pt(std::vector<int>, std::vector<int>::size_type);

int main(int argc, char** argv)
{
    int ia[10];
    for (std::size_t i = 0; i < 10; ++i)
    {
        get(ia, i) = i;
    }

    for(std::size_t i = 0; i < 10; ++i)
    {
        std::cout << ia[i];
    }

    std::cout << std::endl;

    // recursive printing of vector
    std::vector<int> numbers {3,0,2,8,5,1,4};
    recu_vec_pt(numbers, 0);
    std::cout << std::endl;

    return 0;
}

void recu_vec_pt(std::vector<int> ivec, std::vector<int>::size_type ind)
{
    if (ind < ivec.size())
    {
        std::cout << ivec[ind];
        recu_vec_pt(ivec, ++ind);
    }
}
