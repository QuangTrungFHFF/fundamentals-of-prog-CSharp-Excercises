using System;
using System.Collections.Generic;

namespace Exercise01
{
    /// <summary>
    /// Write a program that reads from the console a sequence of positive integer numbers.
    /// The sequence ends when empty line is entered.
    /// Calculate and print the sum and the average of the sequence.
    /// Keep the sequence in List<int>.
    /// </summary>
    class SequenceSumAndAverage
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>();
            string input;
            Console.WriteLine("Please in put a sequence of positive interger number!");
            input = Console.ReadLine();
            while(input!=null&&input!="")
            {
                if(!IsValid(input))
                {
                    Console.WriteLine("Invalid input. Must be a positive interger number!");
                }
                else
                {
                    sequence.Add(int.Parse(input));
                }
                Console.WriteLine("Please in put a positive interger number!");
                input = Console.ReadLine();
            }
            foreach(int i in sequence)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the interger list is: {0}", GetSum(sequence));
            Console.WriteLine("Average of the list is: {0:N2}", GetAverage(sequence));
            Console.ReadKey();
        }
        /// <summary>
        /// Check if input is a positive interger number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsValid(string input)
        {
            int num =-1;
            if(!int.TryParse(input,out num))
            {
                return false;
            }
            if(num>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int GetSum(List<int> listOfInterger)
        {
            int sum = 0;
            foreach(int i in listOfInterger)
            {
                sum += i;
            }
            return sum;
        }
        public static double GetAverage(List<int> listOfInterger)
        {
            return (double)GetSum(listOfInterger) / listOfInterger.Count;
        }
    }
}
