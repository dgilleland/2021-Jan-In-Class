using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox.CardGames
{
    /// <summary>
    /// An abstract representation of a list of PlayingCard.
    /// </summary>
    public abstract class SetOfCards // An abstract class cannot of itself be instantiated
    {
        protected static Random Rnd = new Random();
        // Protected keyword means private to the "outside" world, but public to any class that inherits from this class
        protected List<PlayingCard> Cards { get; set; } // Starting out with an empty list
            = new List<PlayingCard>();
    }
}
