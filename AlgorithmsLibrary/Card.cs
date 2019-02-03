using System;

namespace AlgorithmsLibrary
{
    public class Card
    {
        public Suit Suit { get; private set; }
        public CardRank Rank { get; private set; }
        public Card(Suit suit, CardRank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public override string ToString()
        {
            return $"({Suit}: {Rank})";
        }
    }
}
