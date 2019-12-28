using System;
using System.Collections.Generic;

namespace Exercise08
{
    /// <summary>
    /// The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    /// Write a program that finds the majorant of given array and prints it.
    /// If it does not exist, print "The majorant does not exist!".
    /// </summary>
    internal class Majorant
    {
        private static void Main(string[] args)
        {
            var numberList = new List<int> { 1, 1, 1, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 0, 0, 0, 0, 4, 4, 4, 4, 4 };
            var numberListB = new List<int> { 1, 2, 6, 5, 3, 3, 3, 3, 3, 3, 9, 3, 3, 5 };
            FindMajorant(numberList);
            FindMajorant(numberListB);
            Console.ReadKey();
        }

        public static void FindMajorant(List<int> numberList)
        {
            var list = new List<int>(numberList);
            list.Sort();
            int count = 1;
            int maxCount = 1;
            int maxOccurence = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] != list[i - 1])
                {
                    if (count > maxCount)
                    {
                        maxOccurence = list[i - 1];
                        maxCount = count;
                    }
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxOccurence = list[list.Count - 1];
                maxCount = count;
            }
            if (maxCount > list.Count / 2)
            {
                Console.WriteLine("There is a majorant: {0}, occurs: {1} times", maxOccurence, maxCount);
            }
            else
            {
                Console.WriteLine("There is no majorant!");
            }
        }
    }
}