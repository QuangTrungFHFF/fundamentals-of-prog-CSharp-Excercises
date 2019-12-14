using System;
using System.Collections.Generic;

namespace Exercise15
{
    /// <summary>
    /// A dictionary is given, which consists of several lines of text. Each line consists of a word and its explanation, separated by a hyphen.
    /// Write a program that parses the dictionary and then reads words from the console in a loop, gives an explanation for it or writes a message
    /// on the console that the word is not into the dictionary.
    /// </summary>
    internal class Dictionary
    {
        private static Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"Apple","A round fruit with firm, white flesh and a green, red, or yellow skin." },
            {"Durian","A large, oval, tropical fruit with a hard skin covered in sharp points, yellow, orange, or red flesh, and a very strong smell." },
            {"Orange","A round sweet fruit that has a thick orange skin and an orange centre divided into many parts" }
        };

        private static void Main(string[] args)
        {
            string word = String.Empty;
            while (!word.Equals("/Q"))
            {
                Console.WriteLine(@"Please enter a word to begin search!");
                word = Console.ReadLine();
                while (!dictionary.ContainsKey(word) && !word.Equals("//Q"))
                {
                    Console.WriteLine("Word not found! Do you want to add {0} to the Dictionary? (Y/N)", word);
                    if (Console.ReadLine() == "Y")
                    {
                        Console.WriteLine("Please enter the explanation for {0}.", word);
                        CreateNewEntry(word, Console.ReadLine());
                    }
                    Console.WriteLine("Please enter a word to begin search!");
                    word = Console.ReadLine();
                }
                Console.WriteLine("Search result: {0} - {1}", word, dictionary[word]);
                Console.WriteLine(@"Do you want to continue? (Y/N)");
                word = Console.ReadLine();
                while (!word.Equals("Y") && !word.Equals("N"))
                {
                    Console.WriteLine(@"Invalid input. Do you want to continue? (Y/N)");
                    word = Console.ReadLine();
                }
                if (word.Equals("N")) word = "/Q";
            }
        }

        /// <summary>
        /// Add new word to the dictionary.
        /// </summary>
        /// <param name="newWord">explanation of the word</param>
        private static void CreateNewEntry(string newWord, string explanation)
        {
            if (explanation == null)
            {
                Console.WriteLine("Invalid format!");
            }
            else
            {
                dictionary.Add(newWord, explanation);
                Console.WriteLine("Word successfully added to the dictionary!");
            }
        }
    }
}