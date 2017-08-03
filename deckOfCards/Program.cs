using System;

namespace DeckOfCards
{
    class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            Player one = new Player("B");
            System.Console.WriteLine(myDeck);
        }
    }
}
