using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    public class Program{

        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            RandomArray();
            TossCoin();
            MultipleCoinToss(5);
            Names();
        }

        static int[] RandomArray() {
            Random rand = new Random();
            int[] randArr = new int[10];
            int sum = 0;
            for(int idx = 0; idx < randArr.Length; idx++) {
                //Up to 26 since .Next is non-inclusive
                int val = rand.Next(5,26);
                randArr[idx] = val;
                sum += val;
            }
            Console.WriteLine("The max value of the random array is {0}", randArr.Max());
            Console.WriteLine("The min value of the random array is {0}", randArr.Min());
            return randArr;
        }

        static string TossCoin(){
            System.Console.WriteLine("Tossing a coin...");
            Random RandObj = new Random();
            int CoinToss = RandObj.Next(0,2);
            string res = "Tails";
            if(CoinToss == 0){
                System.Console.WriteLine("Heads");
                res = "Heads";
            } else {
                System.Console.WriteLine("Tails");
            }
            return res;
        }

        static Double MultipleCoinToss(int num){
            int countHeads = 0;
            for(int i = 0; i < num; i++){
                if(TossCoin() == "Heads"){
                    countHeads++;
                }
            // System.Console.WriteLine((double)countHeads/(double)num);   
            }
            return (double)countHeads/(double)num;
        }

        static string[] Names() {
            string[] names = new string[5] {"Todd","Tiffany","Charlie","Geneva","Sydney"};
            //Fisher-Yates Shuffle
            Random rand = new Random();
            for(var idx = 0; idx < names.Length - 1; idx++){
                int randIdx = rand.Next(idx + 1, names.Length - 1);
                string temp = names[idx];
                names[idx] = names[randIdx];
                names[randIdx] = temp;
                //Print each name in it's new position
                Console.WriteLine(names[idx]);
            }
            //Don't forget the last value!
            Console.WriteLine(names[names.Length - 1]);

            //Return an array the only includes names longer than 5
            List<string> nameList = new List<string>();
            foreach(var name in names) {
                nameList.Add(name);
            }
            return nameList.ToArray();
        }
    }
}