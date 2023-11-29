using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Hawley
{
    /// <summary>
    /// Represents a deck of cards.
    /// </summary>
    class Deck
    {
        /// <summary>
        /// Stored the cards in a deck.
        /// </summary>
        private List<Card> cards;

        /// <summary>
        /// Constructs a deck of 52 cards.
        /// </summary>
        public Deck()
        {
            cards = new List<Card>();

            for(int i = 0; i <= 3; i++)
            {
                for(int j = 1; j <= 13; j++)
                {
                    Card c = new Card((Suit)i, (Face)j);
                    cards.Add(c);
                }
            }
        }

        /// <summary>
        /// Constructs a deck with the given cards.
        /// </summary>
        /// <param name="cards">The cards passed into the deck.</param>
        public Deck(List<Card> cards)
        {
            this.cards = cards;
        }

        /// <summary>
        /// Selects a random card from the list and removes it.
        /// </summary>
        /// <returns>Random card from the deck.</returns>
        public Card GetRandomCard(Random rng)
        {
            int index = rng.Next(0, cards.Count());
            Card c = cards[index];
            cards.RemoveAt(index);
            return c;
        }

        /// <summary>
        /// Counts the number of remining cards.
        /// </summary>
        /// <returns>Number of remaining cards.</returns>
        public int CountRemainingCards()
        {
            return cards.Count();
        }

        /// <summary>
        /// Selects the top card in the deck.
        /// </summary>
        /// <returns>Top card in the deck.</returns>
        public Card GetTopCard()
        {
            Card c = cards[0];
            cards.RemoveAt(0);
            return c;
        }
    }
}
