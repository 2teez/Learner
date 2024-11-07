#ifndef ROUTESTRATEGY_H
#define ROUTESTRATEGY_H

#include <string>

struct route_strategy {
    route_strategy() = delete;
    route_strategy(const std::string&, const std::string&);
    virtual std::string calculate_route() const = 0;

    virtual ~route_strategy() = 0;

    private:
        std::string origin;
        std::string destination;
};

#endif //ROUTESTRATEGY_H
