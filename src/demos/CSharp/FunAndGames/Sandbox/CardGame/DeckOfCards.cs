using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.CardGame
{
    public class DeckOfCards
    {
        public List<PlayingCard> Cards { get; private set; }
        public DeckOfCards()
        {
            Cards = new List<PlayingCard>(); // Set up an empty list
            // Fill it with all the suits/values
            var allSuits = Enum.GetValues(typeof(CardSuit));
            var allValues = Enum.GetValues(typeof(CardValue));
            foreach (CardSuit suit in allSuits)
                foreach (CardValue value in allValues)
                    Cards.Add(new PlayingCard(suit, value));
        }
    }
}
