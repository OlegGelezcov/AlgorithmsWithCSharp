using AlgorithmsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace AlgorithmsConsole
{
    public class CardDeckTool
    {
        public int GroupCount { get; private set; }
        public int NumCardsInGroup { get; private set; }

        public CardDeckTool(int groupCount, int numCardsInGroup )
        {
            this.GroupCount = groupCount;
            this.NumCardsInGroup = numCardsInGroup;
        }

        public void MakeGroups()
        {
            CardDeck deck = new CardDeck();
            var groups = deck.MakeGroups(GroupCount, NumCardsInGroup);
            foreach(var cardGroup in groups )
            {
                PrintGroup(cardGroup);
            }
        }

        private void PrintGroup(Card[] cards )
        {
            var orderedCards = cards.OrderBy(c => (int)c.Suit).ThenBy(c => (int)c.Rank);
            foreach(var card in orderedCards )
            {
                WriteLine(card.ToString());
            }
            WriteLine("---");
        }
    }
}
