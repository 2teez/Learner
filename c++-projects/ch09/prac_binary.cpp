#include <algorithm>
#include <iostream>
#include <cctype>
#include <sstream>

bool is_vowel(char);
std::string get_binary(int);

int main(int argc, char** argv) {

    char ch {};
    std::cout << "Enter a character: ";
    std::cin >> ch;

    if (!std::islower(ch) && !is_vowel(ch)) {
        std::cout << ch << " not a lowercase or a vowel\n";
    } else {
        int result {static_cast<int>(ch)};
        std::cout << ch << ":" << //std::hex
        result << std::dec << "::" << get_binary(result)<< std::endl;
    }
    return 0;
}

std::string get_binary(int value) {
    std::ostringstream os {};
    while (true) {
        if (value == 0) break;
        os << std::to_string(value % 2);
        value/=2;
    }
    auto result = os.str();
    std::reverse(result.begin(), result.end());
    return result;
}

bool is_vowel(char ch) {
    for (const auto c: "aeiou") {
        if (c == ch) return true;
    }
    return false;
}
