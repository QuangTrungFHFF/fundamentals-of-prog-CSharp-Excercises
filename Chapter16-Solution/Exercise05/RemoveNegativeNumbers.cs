using System;
using System.Collections.Generic;

namespace Exercise05
{
    /// <summary>
    /// Write a program, which removes all negative numbers from a sequence.
    /// </summary>
    internal class RemoveNegativeNumbers
    {
        private static void Main(string[] args)
        {
            var numberList = new List<int> { 1, -15, 2, 5, 7, -8, -9, 5, -8, 445, 58, -8, -120, 1, 2, 3 };
            var positiveList = RemoveNegative(numberList);
            foreach (int i in positiveList)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        public static List<int> RemoveNegative(List<int> numberList)
        {
            var positiveList = new List<int>();
            for(int i =0;i<numberList.Count;i++)
            {
                if(numberList[i]>=0)
                {
                    positiveList.Add(numberList[i]);
                }
            }
            return positiveList;
        }
    }
}