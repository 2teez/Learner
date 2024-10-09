
#include <iostream>
#include <ctime>
#include <string>

namespace Month {
    std::string months[] = {
        "Jan", "Feb", "Mar", "Apr", "May", "Jun",
        "Jul", "Aug", "Sep", "Oct", "Nov", "Dec",
    };

    std::string name(int mon) {
        std::string month {};
        switch (mon) {
          case 0: month = months[mon]; break;
          case 1: month = months[mon]; break;
          case 2: month = months[mon]; break;
          case 3: month = months[mon]; break;
          case 4: month = months[mon]; break;
          case 5: month = months[mon]; break;
          case 6: month = months[mon]; break;
          case 7: month = months[mon]; break;
          case 8: month = months[mon]; break;
          case 9: month = months[mon]; break;
          case 10: month = months[mon]; break;
          case 11: month = months[mon]; break;
        }
        return month;
    }
};

int main(int argc, char** argv) {
    std::time_t current_time = std::time(nullptr);
    std::tm* localtime = std::localtime(&current_time);
    std::cout << "Current time is: " << std::asctime(localtime) << std::endl;

    // extract year, month and day of the month
    // get year
    std::cout << localtime->tm_year+1900 << std::endl;
    std::cout << Month::name(localtime->tm_mon) << std::endl;
    std::cout << localtime->tm_mday << std::endl;
    return 0;
}
