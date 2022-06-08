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

            deckOne = Shuffle(deckOne);

            foreach (Card card in deckOne.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> tempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                tempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = tempList;
            return deck;
        }
    }
}
