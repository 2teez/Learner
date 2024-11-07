/*
from abc import ABC, abstractmethod

# Abstract base class for different types of transport
class Transport(ABC):
    def __init__(self, speed: float, fuel_type: str):
        self.speed = speed
        self.fuel_type = fuel_type

    @abstractmethod
    def max_distance(self) -> float:
        """Calculate the maximum distance based on fuel or energy source."""
        pass

    @property
    @abstractmethod
    def description(self) -> str:
        pass

# Strategy base class for routes
class RouteStrategy(ABC):
    @abstractmethod
    def calculate_route(self, origin: str, destination: str) -> str:
        pass

# Concrete strategy for a short route
class ShortRouteStrategy(RouteStrategy):
    def calculate_route(self, origin: str, destination: str) -> str:
        return f"Shortest route from {origin} to {destination}"

# Concrete strategy for a scenic route
class ScenicRouteStrategy(RouteStrategy):
    def calculate_route(self, origin: str, destination: str) -> str:
        return f"Scenic route from {origin} to {destination}"

# Concrete class Car implementing Transport
class Car(Transport):
    def __init__(self, speed: float, fuel_capacity: float):
        super().__init__(speed, fuel_type="Gasoline")
        self.fuel_capacity = fuel_capacity

    def max_distance(self) -> float:
        return self.fuel_capacity * 15  # assuming 15 km per liter

    @property
    def description(self) -> str:
        return f"Car with a top speed of {self.speed} km/h and max range {self.max_distance()} km."

# Concrete class Bicycle implementing Transport
class Bicycle(Transport):
    def __init__(self, speed: float):
        super().__init__(speed, fuel_type="Human Power")

    def max_distance(self) -> float:
        return 50  # assuming a typical range for cycling

    @property
    def description(self) -> str:
        return f"Bicycle with a top speed of {self.speed} km/h and max range {self.max_distance()} km."

# Context class that uses a RouteStrategy
class RoutePlanner:
    def __init__(self, strategy: RouteStrategy):
        self._strategy = strategy

    def set_strategy(self, strategy: RouteStrategy):
        self._strategy = strategy

    def plan_route(self, origin: str, destination: str) -> str:
        return self._strategy.calculate_route(origin, destination)

# Example usage
car = Car(speed=120, fuel_capacity=40)
bike = Bicycle(speed=20)

planner = RoutePlanner(ShortRouteStrategy())
print(car.description)
print(bike.description)
print(planner.plan_route("City A", "City B"))

# Switching to a scenic route
planner.set_strategy(ScenicRouteStrategy())
print(planner.plan_route("City A", "City B"))

*/
#include <iostream>
#include <memory>
#include "routestrategy.h"
#include "transport.h"
#include "car.cpp"
#include "bicycle.cpp"
#include "routestrategy.cpp"
#include "routeplanner.cpp"

int main(int argc, char** argv) {

    // Example usage
    auto car {Car(120, 40)};
    auto bike {Bicycle(20)};

    std::shared_ptr<route_strategy> srs {std::make_shared<short_route_strategy>(short_route_strategy("City A", "City B"))};
    auto planner {Route_Planner(srs)};
    std::cout << car.description() << '\n';
    std::cout << bike.description() << '\n';
    std::cout << planner.plan_route("City A", "City B") << '\n';

    // Switching to a scenic route
    auto srs_cl {std::make_shared<Scenic_Route_Strategy>(Scenic_Route_Strategy())};
    planner.set_strategy(srs_cl);
    std::cout << planner.plan_route("City A", "City B") << '\n';

    return 0;
}
