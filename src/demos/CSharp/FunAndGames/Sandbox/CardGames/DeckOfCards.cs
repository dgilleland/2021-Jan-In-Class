using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.CardGames
{
    /// <summary>
    /// A fresh set of 52 cards of all card suits/values in order
    /// </summary>
    /// <seealso cref="Sandbox.CardGames.SetOfCards" />
    public class DeckOfCards : SetOfCards // DeckOfCards is a "concrete" class, and can be instantiated
    {
        public DeckOfCards()
        {
            // Create a card of each combination of CardSuits and CardValues
            var allSuits = Enum.GetValues(typeof(CardSuit));
            var allValues = Enum.GetValues(typeof(CardValue));
            foreach (CardSuit suit in allSuits)
                foreach (CardValue value in allValues)
                    Cards.Add(new PlayingCard(suit, value));
        }
        public void Shuffle()
        {
            for (int counter = 0; counter < 500; counter++)
            {
                int index = Rnd.Next(Cards.Count);
                PlayingCard card = Cards[0];
                Cards.RemoveAt(0);
                Cards.Insert(index, card);
            }
        }
    }
}
