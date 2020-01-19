using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise07
{
    /// <summary>
    /// Write a program that finds in a given array of integers (in the range [0…1000]) how many times each of them occurs.
    /// </summary>
    internal class NumberOccurrence
    {
        private static void Main(string[] args)
        {
            var numberList = new List<int> { 1, 1, 1, 2, 2, 3, 3, 3, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 0, 0, 0, 0, 4, 4, 4, 4, 4 };
            var list = GetRandomList(777);
            PrintOccurrence(numberList);
            Console.WriteLine("--------------------------------------");
            PrintOccurrence(list);
        }

        /// <summary>
        /// Generate a List with n random elements
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<int> GetRandomList(int n)
        {
            var randomList = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                randomList.Add(rand.Next(0, 100));
            }
            return randomList;
        }

        public static void PrintOccurrence(List<int> list)
        {
            List<int> tempList = list.ToList();
            int count = 1;
            tempList.Sort();
            for (int i = 1; i < tempList.Count; i++)
            {
                if (tempList[i] == tempList[i - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Element: {0} --- Number of Occurrences: {1}", tempList[i - 1], count);
                    count = 1;
                }
            }
        }
    }
}