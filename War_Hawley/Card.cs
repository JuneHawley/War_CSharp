using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War_Hawley
{
    enum Suit
    {
        Diamond,
        Hearts,
        Spades,
        Clubs
    }

    enum Face
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    /// <summary>
    /// Represents a card in a deck.
    /// </summary>
    class Card
    {
        /// <summary>
        /// Suit of the card
        /// </summary>
        public Suit Suit { get; set; }

        /// <summary>
        /// Face of the the card.
        /// </summary>
        public Face Face { get; set; }

        /// <summary>
        /// Constructs a new card object with the given Suit and Face.
        /// </summary>
        /// <param name="suit">The suit of the card.</param>
        /// <param name="face">The face of the card.</param>
        public Card(Suit suit, Face face)
        {
            this.Suit = suit;
            this.Face = face;
        }

        /// <summary>
        /// Compares the current card to the passed card.
        /// </summary>
        /// <param name="other">Other card to compare to.</param>
        /// <returns>Returns a negative number if the current card is
        /// higher than the other card. Returns 0 if they are the same.</returns>
        public int ComepareTo(Card other)
        {
            return this.Face - other.Face;
        }
    }
}
