using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {

            Deck deckOne = new Deck();
            deckOne.Shuffle(3);

            foreach (Card card in deckOne.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.ReadLine();
        }
    }
}
