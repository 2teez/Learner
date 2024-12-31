namespace CardLib;

public class Card
{
    public readonly Suit suit;
    public readonly Rank rank;
    private Card() { }
    public Card(Suit suit, Rank rank)
    {
        this.suit = suit;
        this.rank = rank;
    }
    public override string ToString() => $"Card{{ {suit}, {rank}}}";
}
