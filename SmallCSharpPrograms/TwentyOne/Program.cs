using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob"};
            game.ListPlayers();
            Console.ReadLine();

            //Deck deckOne = new Deck();
            //deckOne.Shuffle(3);

            //foreach (Card card in deckOne.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.ReadLine();
        }
    }
}
