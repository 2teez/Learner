using Vehicles;

class ClassDemo
{
    static void Main()
    {
        Console.WriteLine(AddPassenger(new Compact()));
        Console.WriteLine(AddPassenger(new SUV()));
        Console.WriteLine(AddPassenger(new PassengerTrain()));
    }
    static IPassengerCarrier AddPassenger(IPassengerCarrier pc)
    {
        return pc switch
        {
            Compact => new Compact(),
            SUV => new SUV(),
            PassengerTrain => new PassengerTrain(),
            _ => new Compact(),
        };
    }
}
