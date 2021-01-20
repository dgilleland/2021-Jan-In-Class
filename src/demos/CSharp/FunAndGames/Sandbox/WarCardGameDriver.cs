using Sandbox.CardGame;
using System;
using System.Linq;

namespace Sandbox
{
    public class WarCardGameDriver
    {
        /* Game Play
         * Two players start with 1/2 of a deck of cards each (cards are dealt to the players one at a time)
         * Both players turn over a card from the top of their deck to show the value.
         * Whoever's card is of the greater value (CardValue) wins both of the cards.
         * If there is a tie in value, then a "war" is started where three cards each are laid down, and a fourth card is revealed and they are again compared.
         * The winner's cards are added to the end of their deck.
         * Game play continues until one player loses all their cards.
         */
        public void Start()
        {
            Welcome();
            // General Setup
            // 1) Shuffle a new deck
            DeckOfCards startingDeck = new DeckOfCards();
            startingDeck.Shuffle();
            // 2) Deal out the cards to each player
            while(startingDeck.NotEmpty)
            {
                Player1.Add(startingDeck.DrawCard());
                Player2.Add(startingDeck.DrawCard());
            }
            PlayGame();
        }
        void PlayGame()
        {
            throw new NotImplementedException();
        }

        private HandOfCards Player1 = new HandOfCards();
        private HandOfCards Player2 = new HandOfCards();
        void Welcome()
        {
            throw new NotImplementedException();
        }
    }
}
