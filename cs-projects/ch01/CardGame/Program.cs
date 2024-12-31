
using CardLib;

class CardTest
{
    static void Main(string[] args)
    {
        Deck deck = new Deck();
        deck.Shuffle();
        Console.WriteLine(deck.GetCard(new Random().Next(52)));
    }
}
