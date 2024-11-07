#include "routestrategy.h"

inline route_strategy::route_strategy(const std::string& origin,
    const std::string& destination): origin {origin}, destination {destination} {}

inline route_strategy::~route_strategy() {}

struct short_route_strategy: public route_strategy {
    public:
        short_route_strategy(): route_strategy{"", ""},
            origin{""}, destination {""} {}
            short_route_strategy(const std::string& origin,
            const std::string& destination): route_strategy{origin, destination},
                origin{origin}, destination {destination}
        {}

        std::string calculate_route() const {
            std::string str {"Shortest route from"};
            str += std::string(origin) + "to ";
            str += std::string(destination) + "\n";
            return std::string(str);
        }

        inline ~short_route_strategy(){}

    private:
        std::string origin;
        std::string destination;
};

class Scenic_Route_Strategy: public route_strategy {
    public:
        Scenic_Route_Strategy(std::string origin = "",
            std::string destination = ""):
        route_strategy{origin, destination},
        origin{origin}, destination {destination} {}

        std::string calculate_route() const {
            std::string str {"Shortest route from "};
            str += std::string(origin);
            str += "to ";
            str += std::string(destination) + "\n";
            return std::string(str);
        }

        ~Scenic_Route_Strategy(){}
    private:
        std::string origin;
        std::string destination;
};
