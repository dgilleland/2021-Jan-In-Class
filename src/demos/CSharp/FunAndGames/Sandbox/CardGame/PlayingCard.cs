using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.CardGame
{
    public class PlayingCard // inherits from the Object class
    {
        public CardSuit Suit { get; private set; }
        public CardValue Value { get; private set; }
        public PlayingCard(CardSuit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }
        public override string ToString() // We are overriding the default implementation of the ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
