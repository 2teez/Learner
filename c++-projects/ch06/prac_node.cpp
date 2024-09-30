
#include <iostream>
#include <cstddef>

typedef struct ListNode {
    std::string item;
    int count;
    //ListNode() = delete;
    //ListNode(std::string item, int count): item(item), count(count) {}
} ListNode, *ListNodePtr;

int main(int argc, char** argv) {
    ListNodePtr head = new ListNode;//("vector", 12);
    std::cout << head->item << head->count << std::endl;

    head->item = "bagels"; head->count = 23;
    std::cout << head->item << head->count << std::endl;

   return 0;
}
