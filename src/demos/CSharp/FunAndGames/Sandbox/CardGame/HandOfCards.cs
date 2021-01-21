using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.CardGame
{
    public class HandOfCards
    {
        private List<PlayingCard> Cards = new List<PlayingCard>();

        public bool HasCards { get { return Cards.Count > 0; } }
        public int Count { get { return Cards.Count; } }

        public void Add(PlayingCard drawCard)
        {
            Cards.Add(drawCard);
        }
        public void Add(IEnumerable<PlayingCard> cards)
        {
            foreach (var card in cards)
                Add(card);
        }
        public PlayingCard ShowCard()
        {
            return Cards[0];
        }

        public IEnumerable<PlayingCard> RemoveTopCard(int count)
        {
            var top = Cards.Take(count);
            foreach(var card in top)
                Cards.Remove(card);
            return top;
        }
    }
}
