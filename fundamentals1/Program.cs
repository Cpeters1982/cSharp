using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRINT ALL VALUES FROM 1-255

            for(int i=0; i <=255; i++){
                Console.WriteLine(i);
            }


            //PRINT VALUES 1-100 DIVISIBLE BY 3 OR 5, BUT NOT BOTH

            for(int x=0; x <=100; x++){
                if(x % 3 ==0){
                    Console.WriteLine(x);
                }
                if(x % 5 ==0){
                    Console.WriteLine(x);
                }
            }


            //MODIFY PREV

             for(int x=0; x <=100; x++){
                if(x % 3==0 && x % 5==0){
                     Console.WriteLine("FizzBuzz");
                }
                if(x % 3 ==0){
                    Console.WriteLine("Fizz");
                }
                if(x % 5 ==0){
                    Console.WriteLine("Buzz");
                }
            }


            //OPTIONAL FIZZBUZZ WITHOUT MOD

            int three = 3;
            int five = 5;
            for (int num = 1; num < 101; num++)
            {
                three--;
                five--;
                if (three == 0 && five == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    three = 3;
                    five = 5;
                }
                else if (three == 0)
                {
                    Console.WriteLine("Fizz");
                    three = 3;
                }
                else if (five == 0) {
                    Console.WriteLine("Buzz");
                    five = 5;
                }
            }


            //OPTIONAL GENERATE 10 RANDOM VALUES

            Random rand = new Random();
            for(int val = 0; val < 10; val++){
                int Check = rand.Next(1,100);
                Console.WriteLine(Check);
                if(Check % 3==0 && Check % 5==0){
                     Console.WriteLine("FizzBuzz");
                }
                if(Check % 3 ==0){
                    Console.WriteLine("Fizz");
                }
                if(Check % 5 ==0){
                    Console.WriteLine("Buzz");
                }
            }       
        }
    }
}