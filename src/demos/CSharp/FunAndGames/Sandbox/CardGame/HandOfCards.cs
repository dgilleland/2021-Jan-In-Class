using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.CardGame
{
    public class HandOfCards
    {
        private List<PlayingCard> Cards = new List<PlayingCard>();

        public bool HasCards { get { return Cards.Count > 0; } }

        public void Add(PlayingCard drawCard)
        {
            Cards.Add(drawCard);
        }
        public PlayingCard ShowCard()
        {
            return Cards[0];
        }

        public PlayingCard RemoveTopCard()
        {
            PlayingCard top = Cards[0];
            Cards.Remove(top);
            return top;
        }
    }
}
