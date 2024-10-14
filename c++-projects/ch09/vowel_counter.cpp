
#include <iostream>
#include <cctype>
#include <string>

int main(int argc, char** argv) {

    std::cout << "Enter a line of text: ";
    std::string line;
    std::getline(std::cin, line);

    int vowel {0}, consonant {0};

    for (const auto &ch: line) {
        if (std::isalpha(ch)) {
            switch (std::tolower(ch)) {
                case 'a': case 'e': case 'i': case 'o': case 'u':
                  ++vowel;
                  break;
                default:
                  ++consonant;
            }
        }
    }
    std::cout << "Your input contained " << vowel
       << " vowels and " << consonant << " consonants.\n";
    return 0;
}
