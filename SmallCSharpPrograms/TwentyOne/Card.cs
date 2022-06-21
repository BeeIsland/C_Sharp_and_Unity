﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public override string ToString()
        {
            return String.Format("{0} of {1}", Face, Suit);
        }
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
