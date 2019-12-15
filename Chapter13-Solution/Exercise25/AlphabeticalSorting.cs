using System;

namespace Exercise25
{
    /// <summary>
    /// Write a program that reads a list of words separated by commas from the console and prints them in alphabetical order (after sorting).
    /// </summary>
    class AlphabeticalSorting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of words seperated by commas!");
            char[] separator = { ' ', ',' };
            string[] text = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(text, StringComparer.InvariantCultureIgnoreCase);
            for(int i =0; i<text.Length;i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
