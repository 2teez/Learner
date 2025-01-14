using static System.Console;

namespace SwitchExpression
{
    class CheckExperssion
    {
        static void Main(string[] args)
        {
            WriteLine(TwelveDaysOfChristmasSongs(1));
            WriteLine(TwelveDaysOfChristmasSongs());
            WriteLine(TwelveDaysOfChristmasSongs(9));
        }

        static string TwelveDaysOfChristmasSongs(int day = 0) => day switch
        {
            1 => "have a heart",
            _ => "that is all the songs",
        };
    }
}
