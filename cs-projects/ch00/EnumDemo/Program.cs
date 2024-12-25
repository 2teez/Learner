enum TrafficLight
{
    Red,
    Amber,
    Amber_Red,
    Green,
};

class EnumDemo
{
    static void Main(string[] args)
    {
        TrafficLight direction = TrafficLight.Red;
        Console.Write(direction + " - ");
        Console.WriteLine(Direct.Traffic(direction));
        Console.WriteLine(TrafficLight.Amber_Red + " - " + Direct.Traffic(TrafficLight.Amber_Red));
        Console.WriteLine(TrafficLight.Green + " - " + Direct.Traffic(TrafficLight.Green));
    }
}

class Direct
{
    public static string Traffic(TrafficLight status)
    {
        string result = "";
        switch (status)
        {
            case TrafficLight.Amber:
                result = "Get Ready to Wait";
                break;
            case TrafficLight.Green:
                result = "Go";
                break;
            case TrafficLight.Red:
                result = "Stop";
                break;
            case TrafficLight.Amber_Red:
                result = "Get Ready to Go..";
                break;
        }
        return result;
    }
}
