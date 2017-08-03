using System;
using System.Collections.Generic;

namespace thirtyone
{
    public class Game{
        public static Deck newDeck;
        public static List<Player> currPlayers;
        public static List<Card> discard;
        public static int turn;
        public static bool gameActive;
        public Game()
        {
        
            newDeck = new Deck();
            currPlayers = new List<Player>();
            discard = new List<Card>();
            turn = 0;
            gameActive = true;
        }

        public void game(){
            System.Console.WriteLine("♥");
            System.Console.WriteLine("How many players? (4 player max)");
            int numPlayers = Convert.ToInt32(Console.ReadLine());
                if(numPlayers > 4){
                    game();
                }

            for(int i = 0; i < numPlayers; i++){
                currPlayers.Add(new Player(i+1));
            }
            for(int i = 0; i < currPlayers.Count; i++){
                currPlayers[i].DrawFrom(newDeck);
                currPlayers[i].DrawFrom(newDeck);
                currPlayers[i].DrawFrom(newDeck);
                currPlayers[i].getTotal();
            }

            discard.Add(newDeck.Deal());
            // System.Console.WriteLine(discard[0]);

            while(gameActive == true){
                playerTurn();
            }


        }

        public void showDiscard(){
            string kitty = "";
            kitty += $"The top discarded card in the kitty is {discard[discard.Count-1].stringVal} of {discard[discard.Count-1].suit}";
            System.Console.WriteLine(kitty);
        }   

        public void playerTurn(){
            string startTurn = $"player {turn+1} It's your turn!";
            System.Console.WriteLine(startTurn);
            showDiscard();
            currPlayers[turn].ShowHand();
            System.Console.WriteLine("Please enter 'knock' to knock, 'deck' to draw from deck, or 'kitty' to draw from the kitty");
            string decision = Console.ReadLine();
            if(decision == "knock"){

            }
            else if(decision == "deck"){
                deck();
            }
            else if(decision == "kitty"){
                kitty();
            }
            else{
                System.Console.WriteLine("Please enter valid option. Sucker.");
                playerTurn();
            }
        }
        public void knock(){

        }
        public void deck(){
            currPlayers[turn].DrawFrom(newDeck);
            currPlayers[turn].ShowHand();
            System.Console.WriteLine("Please enter the number of the card that you would like to discard");
            int discardChoice = Convert.ToInt32(Console.ReadLine());
            Card discarded = currPlayers[turn].hand[discardChoice-1];
            discard.Add(discarded);
            currPlayers[turn].hand.RemoveAt(discardChoice-1);
            currPlayers[turn].getTotal();
            if(currPlayers[turn].handTotal == 31){
                gameOver();
            }    
            nextTurn();
        }
        public void kitty(){
            currPlayers[turn].hand.Add(discard[discard.Count-1]);
            currPlayers[turn].ShowHand();
            System.Console.WriteLine("Please enter the number of the card that you would like to discard");
            int discardChoice = Convert.ToInt32(Console.ReadLine());
            Card discarded = currPlayers[turn].hand[discardChoice-1];
            discard.Add(discarded);
            currPlayers[turn].hand.RemoveAt(discardChoice-1);
            currPlayers[turn].getTotal();
            if(currPlayers[turn].handTotal == 31){
                gameOver();
            }    
            nextTurn();
        }
        public void nextTurn(){
            if(turn == currPlayers.Count-1){
                turn = 0;
            } else {
                turn++;
            }
        } 
        public void gameOver(){
            string win = $"Player {turn+1} wins!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" 
            System.Console.WriteLine(win);
            System.Console.WriteLine("------------------------------------------------------");
            System.Console.WriteLine("******************************************************");
            System.Console.WriteLine("******************************************************");
            System.Console.WriteLine("******************************************************");
            System.Console.WriteLine("******************************************************");
            System.Console.WriteLine("******************************************************");
            System.Console.WriteLine("******************************************************");
            System.Console.WriteLine("------------------------------------------------------");
            System.Console.WriteLine(win);

        }

        
    }
}


