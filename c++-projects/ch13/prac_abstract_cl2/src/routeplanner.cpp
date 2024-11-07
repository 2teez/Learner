#include "routestrategy.h"
#include <memory>

class Route_Planner {
    public:
        Route_Planner(std::shared_ptr<route_strategy> strategy): strategy {strategy} {}

        void set_strategy(const std::shared_ptr<route_strategy>& new_strategy) {
            strategy = new_strategy;
        }

        std::string plan_route(const std::string& origin, const std::string& destination) {
            return strategy->calculate_route();
        }

        private:
            std::shared_ptr<route_strategy> strategy;
};
