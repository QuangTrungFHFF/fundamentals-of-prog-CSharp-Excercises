using System;
using System.Collections.Generic;

namespace Exercise03
{
    internal class SortedSequence
    {
        /// <summary>
        /// Write a program that reads from the console a sequence of positive integer numbers.
        /// The sequence ends when an empty line is entered. Print the sequence sorted in ascending order.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var sequence = new List<int>();
            string input;
            Console.WriteLine("Please in put a sequence of positive interger number!");
            input = Console.ReadLine();
            while (input != null && input != "")
            {
                if (!IsValid(input))
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
            sequence = AscendingSort(sequence);
            foreach (int i in sequence)
            {
                Console.Write(" " + i);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Check if input is a positive interger number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsValid(string input)
        {
            int num = -1;
            if (!int.TryParse(input, out num))
            {
                return false;
            }
            if (num >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<int> AscendingSort(List<int> listOfInterger)
        {
            listOfInterger.Sort();
            return listOfInterger;
        }
    }
}