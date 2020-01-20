using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise03
{
    /// <summary>
    /// Write a program that counts how many times each word from a given text file words.txt appears in it.
    /// The result words should be ordered by their number of occurrences in the text.
    /// </summary>
    internal class WordsCount
    {
        private static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetFullPath(@"..\..\..\..\" + @"Textfiles\"), "Exercise03.txt");
            var dictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader streamReader = new StreamReader(path))
                    {
                        string line;
                        string[] words;
                        char[] separator = new char[] { ' ', ',', ':', '/', '\\', '?', '!', '.', '*' };
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            words = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string w in words)
                            {
                                int count;
                                if (!dictionary.TryGetValue(w, out count))
                                {
                                    count = 0;
                                }
                                dictionary[w] = count + 1;
                            }
                        }
                    }
                    //Sort the result by number of occurences (descending order)
                    var sortedDictionary = dictionary.ToList();
                    sortedDictionary.Sort((word, nextWord) => nextWord.Value.CompareTo(word.Value));
                    foreach (var d in sortedDictionary)
                    {
                        Console.WriteLine("The word \"{0}\" appears {1} time(s) in the text.", d.Key, d.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine("Error while reading the file {0}", path);
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}