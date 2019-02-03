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

        public void Mix()
        {
            cards = cards.Randomize();
        }

        public List<Card[]> MakeGroups(int numberGroups, int numCardsInGroup)
        {
            int totalCards = numberGroups * numCardsInGroup;
            if(totalCards > cards.Length )
            {
                throw new ArgumentException($"{numberGroups} * {numCardsInGroup} > {cards.Length}");
            }

            Mix();

            List<Card[]> result = new List<Card[]>();
            int cardIndex = 0;
            for(int i = 0; i < numberGroups; i++ )
            {
                Card[] group = new Card[numCardsInGroup];
                for(int j = 0; j < numCardsInGroup; j++ )
                {
                    group[j] = cards[cardIndex++];
                }
                result.Add(group);
            }

            return result;
        }
    }
}
