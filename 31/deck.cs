using System;
using System.Collections.Generic;
namespace thirtyone
{
    public class Deck{
        public List<Card> cards = new List<Card>();
        public Deck(){
            Load();
            Shuffle();
        }

        public void Load(){
            string[] suits = {"♣", "♠", "♥", "♦"};
            foreach (string suit in suits){
                // Console.WriteLine(suit);
                for (int i=1; i<14; i++){
                Card newCard = new Card();
                if(i==1){
                    newCard.stringVal= "Ace";
                    newCard.val = 11;
                    newCard.suit = suit;
                }
                else if(i==11){
                    newCard.stringVal= "Jack";
                    newCard.val = 10;
                    newCard.suit = suit;
                }
                else if(i==12){
                    newCard.stringVal= "Queen";
                    newCard.val = 10;
                    newCard.suit = suit;
                }
                else if(i==13){
                    newCard.stringVal= "King";
                    newCard.val = 10;
                    newCard.suit = suit;
                } else {
                    newCard.stringVal = "";
                    newCard.stringVal += i;
                    newCard.val = i;
                    newCard.suit = suit;
                }
                cards.Add(newCard);
                }
            }
        }

       public void Shuffle(){
            Random rand = new Random();
            int m = 52;
                while(m>0)
            {
                m--;
                int i = rand.Next(m);
                Card temp = cards[m];
                cards[m] = cards[i];
                cards[i] = temp;
                }
        }

        public void ShowCards(){
            foreach(Card card in cards){
                Console.WriteLine(card.val);
                Console.WriteLine(card.stringVal);
                Console.WriteLine(card.suit);
            }
        }
        public void Reset(){
            cards = new List<Card>();
            Load();
        }

        public Card Deal(){
            Card temp =cards[0];
            cards.RemoveAt(0);
            return temp;
        }
    }
}