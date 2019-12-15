using System;

namespace Exercise23
{
    /// <summary>
    /// Write a program that reads a string from the console and prints in alphabetical order all words from the input string and how many times each one of them occurs in the string.
    /// </summary>
    internal class WordsCount
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string!");
            char[] separator = { ' ', '.', ',', '/', '?', '!' };
            string[] textInput = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(textInput, StringComparer.InvariantCultureIgnoreCase);
            if (textInput != null)
            {
                CountWords(textInput);
            }
        }

        /// <summary>
        /// Count the frequency usage of each word in the string
        /// </summary>
        /// <param name="input"></param>
        private static void CountWords(string[] input)
        {
            int count = 1;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i].Equals(input[i + 1], StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("Number of word \"{0}\": {1}", input[i], count);
                    count = 1;
                }
            }
            if (input.Length > 0)
            {
                Console.WriteLine("Number of word \"{0}\": {1}", input[input.Length - 1], count);
            }
            else
            {
                Console.WriteLine("The string have no word!");
            }
        }
    }
}