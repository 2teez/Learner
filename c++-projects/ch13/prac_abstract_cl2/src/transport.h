#ifndef TRANSPORT_H
#define TRANSPORT_H

#include <string>

struct transport {
    public:
        transport() = delete;
        transport(float, std::string);
        virtual float max_distance() const = 0;
        virtual std::string description() const = 0;

        //virtual ~transport() = 0;
    private:
        float speed  {0};
        std::string fuel_type  {""};
};

#endif // TRANSPORT_H
