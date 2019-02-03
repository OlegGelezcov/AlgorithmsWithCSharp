using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary
{
    public class CardDeck
    {
        private const int DECK_SIZE = 52;

        private Card[] cards;

        public CardDeck()
        {
            cards = new Card[DECK_SIZE];
            int index = 0;
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    cards[index++] = new Card(suit, rank);
                }
            }
        }
    }
}
