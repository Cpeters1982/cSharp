using System.Collections.Generic;

namespace thirtyone
{
    public class Player{
        public int name;
        public List<Card> hand;
        public int lives;
        public int handTotal;
        
        public Player(int n) {
            hand = new List<Card>();
            name = n;
            lives = 3;
        }

        public void DrawFrom(Deck currentDeck) {
            hand.Add(currentDeck.Deal());
        }

        public Card Discard(int idx) {
            Card temp = hand[idx];
            hand.RemoveAt(idx);
            return temp;
        }

        public void ShowHand() {
            string results = "Cards:  ";
            for(int i = 0; i < hand.Count; i++){
                results += $"{i+1}. {hand[i].stringVal}{hand[i].suit} | ";
            }
            results += $"Hand Total: {handTotal}";
            System.Console.WriteLine(results);
        }
        public void getTotal(){
            int max = 0;
            int total = 0;
            for(int i=0; i<hand.Count; i++){
                if(hand[i].suit== "♦"){
                    total += hand[i].val;
                }
                if(total>max){
                    max = total;
                }
            }
            int total2 = 0;
            for(int i=0; i<hand.Count; i++){
                if(hand[i].suit== "♥"){
                    total2 += hand[i].val;
                }
                if(total2>max){
                    max = total2;
                }
            }
            int total3 = 0;
            for(int i=0; i<hand.Count; i++){
                if(hand[i].suit== "♠"){
                    total3 += hand[i].val;
                }
                if(total3>max){
                    max = total3;
                }
            }
            int total4 =0;
            for(int i=0; i<hand.Count; i++){
                if(hand[i].suit== "♣"){
                    total4 += hand[i].val;
                }
                if(total4>max){
                    max = total4;
                }
            }
            handTotal = max;
        }
    }
}
