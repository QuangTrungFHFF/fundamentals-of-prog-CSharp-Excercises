using System;
using System.Collections.Generic;
namespace Exercise02
{
    /// <summary>
    /// Write a program to remove from a sequence all the integers, which appear odd number of times.
    /// For instance, for the sequence {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6} the output would be {5, 3, 3, 5}.
    /// </summary>
    class RemoveNumbersWithOddOccurences
    {
        static void Main(string[] args)
        {
            var sequence = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };
            var newSequence = new List<int>();
            Console.WriteLine("New sequence: ");
            foreach (int i in sequence)
            {
                Console.Write(i + " ");
            }

            var oddDictionary = new Dictionary<int, int>();
            foreach(int i in sequence)
            {
                int count;
                if(!oddDictionary.TryGetValue(i,out count))
                {
                    count = 0;
                }
                oddDictionary[i] = count + 1;
            }
            foreach(int i in sequence)
            {
                if(oddDictionary[i]%2==0)
                {
                    newSequence.Add(i);
                }
            }

            Console.WriteLine("\nNew sequence: ");
            foreach(int i in newSequence)
            {
                Console.Write(i + " ");
            }
        }
    }
    
}
