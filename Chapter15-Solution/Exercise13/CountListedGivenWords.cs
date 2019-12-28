using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise13
{
    /// <summary>
    /// Write a program that reads a list of words from a file called words.txt, counts how many times each of these words is found in another file text.txt,
    /// and records the results in a third file – result.txt, but before that, sorts them by the number of occurrences in descending order.
    /// </summary>
    internal class RemoveListedGivenWords
    {
        private static void Main(string[] args)
        {
            string sourceFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(sourceFolder, "Exercise13Source.txt");
            string wordFile = Path.Combine(sourceFolder, "Exercise13Words.txt");
            string outputFile = Path.Combine(sourceFolder, "Exercise13out.txt");
            string line;
            char[] seperator = { ' ', ',', '.', ';', ':', '?', '!', '-', '(', ')' };
            string[] wordsInLines;
            List<string> content = new List<string>();
            //Create a hash table to store all words in wordFile
            var WordList = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using StreamReader wordFileReader = new StreamReader(wordFile);
            while ((line = wordFileReader.ReadLine()) != null)
            {
                WordList.Add(line, 0);
            }
            //Read the source text file and count all words that occur in wordList
            using StreamReader sourceFileReader = new StreamReader(sourceFile);
            using StreamWriter outputFileWriter = new StreamWriter(outputFile, false);
            while ((line = sourceFileReader.ReadLine()) != null)
            {
                wordsInLines = line.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                foreach (string w in wordsInLines)
                {
                    content.Add(w);
                }
            }

            WordList = CountWords(content, WordList);
            //Sort and write result to new file
            WordList = SortByValue(WordList);
            foreach (KeyValuePair<string, int> word in WordList)
            {
                outputFileWriter.WriteLine(string.Format("Key = \"{0}\", Value = {1}", word.Key, word.Value));
                Console.WriteLine("Key = \"{0}\", Value = {1}", word.Key, word.Value);
            }
            Console.WriteLine("Completed!");
        }

        /// <summary>
        /// Rewrite the line
        /// </summary>
        /// <param name="text"></param>
        /// <param name="wordToCount"></param>
        /// <returns></returns>
        public static Dictionary<string, int> CountWords(List<string> text, Dictionary<string, int> WordToCount)
        {
            List<string> keyWords = new List<string>(WordToCount.Keys);
            foreach (string key in keyWords)
            {
                int count = 0;
                foreach (string s in text)
                {
                    if (s.Equals(key, StringComparison.OrdinalIgnoreCase))
                    {
                        count++;
                    }
                }
                WordToCount[key] = count;
            }
            return WordToCount;
        }

        /// <summary>
        /// Sort the dictionary
        /// </summary>
        /// <param name="WordToCount"></param>
        /// <returns></returns>
        public static Dictionary<string, int> SortByValue(Dictionary<string, int> WordToCount)
        {
            var sortedDictionary = WordToCount.OrderByDescending(v => v.Value);
            return sortedDictionary.ToDictionary(k => k.Key, v => v.Value);
        }
    }
}