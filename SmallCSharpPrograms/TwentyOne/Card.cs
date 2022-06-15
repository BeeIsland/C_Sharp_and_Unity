using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = Suit.Spades;
            Face = Face.Ace;
        }
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit
    {
        Spades,
        Diamonds,
        Clubs,
        Hearts
    }

    public enum Face
    {
        Ace,
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
}
