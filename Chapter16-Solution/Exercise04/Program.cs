using System;
using System.Collections.Generic;

namespace Exercise04
{
    /// <summary>
    /// Write a method that finds the longest subsequence of equal numbers in a given List<int> and returns the result as new List<int>.
    /// Write a program to test whether the method works correctly.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numberList = new List<int> { 1, 5, 9, 8, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 1, 4, 7, 7, 7, 7, 7, 4, 5, 2, 3 };
            //var numberList = new List<int> { 1,1,1,1,2,2,2,2,2,3,4,5 };
            var subsequence = GetSubsequence(numberList);
            foreach(int i in subsequence)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        public static List<int> GetSubsequence(List<int> numberList)
        {            
            int count = 1;
            int maxCount = 1;
            int max=numberList[0];
            var result = new List<int>();            
            for (int i = 1; i < numberList.Count; i++)
            {
                if (numberList[i] == numberList[i-1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        max = numberList[i-1];
                        maxCount = count;
                    }                    
                    count = 1;
                }                
            }
            for (int j =0; j<maxCount;j++)
            {
                result.Add(max);
            }
            return result;
        }
    }
}