using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.CardGames
{
    public class PlayingCard // When we don't specify the class we are inheriting, our class inherits from Object
    {
        public CardSuit Suit { get; private set; }
        public CardValue Value { get; private set; }
        public PlayingCard(CardSuit suit, CardValue value)
        {
            Value = value;
            Suit = suit;
        }
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
