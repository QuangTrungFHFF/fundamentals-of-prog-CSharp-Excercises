using System;
using System.Collections.Generic;
namespace Exercise01
{
    class CountNumberOccurences
    {
        /// <summary>
        /// Write a program that counts, in a given array of integers, the number of occurrences of each integer.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var occurrencesDictionary = new Dictionary<int, int>();
            foreach(int i in numbers)
            {
                int count;
                if(!occurrencesDictionary.TryGetValue(i,out count))
                {
                    count = 0;
                }
                occurrencesDictionary[i] = count + 1;
            }
            foreach(var num in occurrencesDictionary)
            {
                Console.WriteLine("Number {0} occurs {1} time(s) in the array.", num.Key, num.Value);
            }
        }
    }
}
