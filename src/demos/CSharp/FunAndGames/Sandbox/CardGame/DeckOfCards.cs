using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.CardGame
{
    public class DeckOfCards
    {
        public List<PlayingCard> Cards { get; private set; }
        public bool NotEmpty { get { return Cards.Count != 0; } }
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
        private static Random Rnd = new Random();
        public void Shuffle()
        {
            for(int counter = 0; counter < 500; counter++)
            {
                int index = Rnd.Next(Cards.Count); // Pick a random position in the deck
                PlayingCard card = Cards[0]; // Grab the top card
                Cards.RemoveAt(0);
                Cards.Insert(index, card); // Put it in the random position
            }
        }
        public PlayingCard DrawCard()
        {
            PlayingCard card = null;
            if(NotEmpty)
            {
                card = Cards[0];
                Cards.Remove(card);
            }
            return card;
        }
    }
}
