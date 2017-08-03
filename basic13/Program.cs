using System;
using System.Collections.Generic;

namespace Basic13
{
    public class Program
    {
        //Prints values 1 through 255
        public static void Print1to255() {
            for(int val=1; val <= 255; val++) {
                Console.WriteLine(val);
            }
        }

        //Print all odd values between 1 and 255
        public static void PrintOdds() {
            for(int val = 1; val < 256; val++) {
                if(val % 2 == 1) {
                    Console.WriteLine(val);
                }
            }
        }

        //Print Sum all number between 0 and 255
        public static void PrintSum() {
            int sum = 0;
            for(int num = 0; num <= 255; num++) {
                sum += num; //sum = sum + num
                Console.WriteLine($"New Number: {num} Sum: {sum}");
            }
        }

        //Iterate through array
        public static void ArrayIterate(int[] arr) {
            string output = "[";
            for(int idx = 0; idx < arr.Length; idx++) {
                output += arr[idx] + ", ";
            }
            output += "]";
            Console.WriteLine(output);
        }

        //Find max value in array
        public static void MaxInArray(int[] arr) {
            int max = arr[0];
            foreach(int val in arr){
                if(val > max) {
                    max = val;
                }
            }
            Console.WriteLine("The max value is {0}", max);
        }

        //Get average value of array
        public static void AvgOfArray(int[] arr) {
            int sum = GetSum(arr);
            Console.WriteLine("This average is " + (double)sum/(double)arr.Length);
        }
        public static int GetSum(int[] arr) {
            int sum = 0;
            for(int num = 0; num < arr.Length; num++) {
                sum += arr[num]; //sum = sum + num
            }
            return sum;
        }

        //Create array of odd numbers between 1 and 255
        public static int[] CreateOddArray() {
            List<int> oddList = new List<int>();
            for(int val = 1; val < 256; val++) {
                if(val % 2 == 1) {
                    oddList.Add(val);
                }
            }
            return oddList.ToArray();
        }

        //Count all values greater than myArr
        public static void GreaterThanY(int[] arr, int y) {
            int count = 0;
            foreach(int val in arr){
                if(val > y) {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} values greater than {y}");
        }

        //Square all values in an arr
        public static void SquareArrayValues(int[] arr) {
            for(int idx = 0; idx < arr.Length; idx++) {
                arr[idx] *= arr[idx];
            }
        }

        //Elimate Negative Numbers in array
        public static void ReplaceNegatives(int[] arr) {
            for(int idx = 0; idx < arr.Length; idx++) {
                if(arr[idx] < 0) {
                    arr[idx] = 0;
                }
            }
        }

        //Find min, max, and average values from array
        public static void MinMaxAvg(int[] arr) {
            int sum = 0;
            int min = arr[0];
            int max = arr[0];
            foreach(int val in arr) {
                sum += val;
                if(val < min) {
                    min = val;
                }
                if(val > max) {
                    max = val;
                }
            }
            Console.WriteLine("The max of the array is {0}, the min is {1}, and the average is {2}", max, min, (double)sum/(double)arr.Length);
        }

        //Shift an array to the front by one number and add 0 to the end
        public static void ShiftLeft(int[] arr) {
            for(int idx = 0; idx < arr.Length - 1; idx++){
                arr[idx] = arr[idx + 1];
            }
            arr[arr.Length - 1] = 0;
        }

        //replace negatives with "dojo"
        public static object[] NumberToString(object[] arr) {
            for(int idx = 0; idx < arr.Length; idx++) {
                if((int)arr[idx] < 0) {
                    arr[idx] = "Dojo";
                }
            }
            return arr;
        }
        public static void Main(string[] args)
        {
            Print1to255();
            PrintOdds();
            PrintSum();
            int[] myArr = new int[6] {1,3,5,7,9,13};
            ArrayIterate(myArr);
            MaxInArray(myArr);
            AvgOfArray(myArr);
            CreateOddArray();
            GreaterThanY(myArr, 4);
            SquareArrayValues(myArr); //Passed by reference
            ReplaceNegatives(myArr); //Passed by reference
            MinMaxAvg(myArr);
            ShiftLeft(myArr);
            object[] boxedArray = new object[] {-1, 3, 2 -16};
            NumberToString(boxedArray);
        }
    }
}