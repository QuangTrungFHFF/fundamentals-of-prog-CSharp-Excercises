using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise06
{
    /// <summary>
    /// Write a program that removes from a given sequence all numbers that appear an odd count of times.
    /// </summary>
    internal class RemoveOddCountNumbers
    {
        private static void Main(string[] args)
        {
            var numberList = new List<int> { 1, 1, 1, 2, 2, 3, 3, 3, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 0, 0, 0, 0, 4, 4, 4, 4, 4 };
            var subsequence = GetListWithoutOddCOunt(numberList);
            foreach (int i in subsequence)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        public static List<int> GetListWithoutOddCOunt(List<int> numberList)
        {
            var removeNumberList = GetOddCountList(numberList);
            var resultList = new List<int>();
            for (int i = 0; i < numberList.Count; i++)
            {
                if (!removeNumberList.Contains(numberList[i]))
                {
                    resultList.Add(numberList[i]);
                }
            }
            return resultList;
        }

        /// <summary>
        /// Get a list of numbers with odd count
        /// </summary>
        /// <param name="numberList"></param>
        /// <returns></returns>
        public static List<int> GetOddCountList(List<int> numberList)
        {
            var checkList = numberList.ToList();
            checkList.Sort();
            int count = 1;
            var numbersWithOddCount = new List<int>();
            for (int i = 1; i < checkList.Count; i++)
            {
                if (checkList[i] == checkList[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count % 2 == 0)
                    {
                        numbersWithOddCount.Add(checkList[i - 1]);
                    }
                    count = 1;
                }
            }
            //Last number check
            if (count % 2 == 0)
            {
                numbersWithOddCount.Add(checkList[checkList.Count - 1]);
            }
            return numbersWithOddCount;
        }
    }
}