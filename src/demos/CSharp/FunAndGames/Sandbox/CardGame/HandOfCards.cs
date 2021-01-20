using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.CardGame
{
    public class HandOfCards
    {
        private List<PlayingCard> Cards = new List<PlayingCard>();

        public void Add(PlayingCard drawCard)
        {
            Cards.Add(drawCard);
        }
    }
}
