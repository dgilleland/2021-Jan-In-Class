using Sandbox.CardGame;
using System;
using static System.Console;
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
            // Loop until one of the players is out of cards
            while(Player1.HasCards && Player2.HasCards)
            {
                _CardCount = 0;
                Battle();
            }
        }
        void Battle()
        {
            // Showing each card
            RevealCards(); // I will only do console I/O from my Driver class
            _CardCount++;
            if(Player1.ShowCard().Value > Player2.ShowCard().Value)
            {
                // Player 1 wins
                Player1.Add(Player1.RemoveTopCard(_CardCount)); // add to the bottom of the deck
                Player1.Add(Player2.RemoveTopCard(_CardCount)); // gets the other player's card
            }
            else if(Player2.ShowCard().Value > Player1.ShowCard().Value)
            {
                // Player 2 wins
                Player2.Add(Player2.RemoveTopCard(_CardCount)); // add to the bottom of the deck
                Player2.Add(Player1.RemoveTopCard(_CardCount));
            }
            else
            {
                // It's a tie
                War();
            }
            WriteLine($"Player 1 has {Player1.Count} cards.");
            WriteLine($"Player 2 has {Player2.Count} cards.");
            WriteLine("Press [enter] to play next hand >> ");
            ReadLine();
        }
        void War()
        {
            WriteLine("!! WAR !!");
            _CardCount++;
            Battle();
        }
        private int _CardCount;
        void RevealCards()
        {
            var card1 = Player1.ShowCard();
            var card2 = Player2.ShowCard();
            Write(card1);
            Write("\t");
            Write(card2);
            WriteLine();
        }

        private HandOfCards Player1 = new HandOfCards();
        private HandOfCards Player2 = new HandOfCards();
        void Welcome()
        {
            WriteLine("WAAARRR!!\n\n");
        }
    }
}
