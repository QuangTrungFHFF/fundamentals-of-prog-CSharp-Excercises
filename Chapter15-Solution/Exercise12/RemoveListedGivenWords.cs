using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise12
{
    /// <summary>
    /// A text file words.txt is given, containing a list of words, one per line.
    /// Write a program that deletes in the file text.txt all the words that occur in the other file.
    /// Catch and handle all possible exceptions.
    /// </summary>
    internal class RemoveListedGivenWords
    {
        private static void Main(string[] args)
        {
            string sourceFolder = Path.GetFullPath(@"..\..\..\..\") + @"Textfiles\";
            string sourceFile = Path.Combine(sourceFolder, "Exercise12Source.txt");
            string wordFile = Path.Combine(sourceFolder, "Exercise12Words.txt");
            string outputFile = Path.Combine(sourceFolder, "Exercise12out.txt");
            //Create a hashset to store all words in wordFile
            var wordList = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            using StreamReader wordFileReader = new StreamReader(wordFile);
            string line;
            while ((line = wordFileReader.ReadLine()) != null)
            {
                wordList.Add(line);
            }
            //Read the source text file and delete all words that occur in wordList
            using StreamReader sourceFileReader = new StreamReader(sourceFile);
            using StreamWriter outputFileWriter = new StreamWriter(outputFile);
            while ((line = sourceFileReader.ReadLine()) != null)
            {
                outputFileWriter.WriteLine(RemoveWords(line, wordList));
            }
            Console.WriteLine("Completed!");
        }

        /// <summary>
        /// Rewrite the line 
        /// </summary>
        /// <param name="line"></param>
        /// <param name="wordToDelete"></param>
        /// <returns></returns>
        public static string RemoveWords(string line, HashSet<string> wordToDelete)
        {            
            string pattern = @"(\.)|(,)|(\s)|(:)";
            StringBuilder newLine = new StringBuilder();
            string[] wordsInLine = Regex.Split(line, pattern);
            foreach (string s in wordsInLine)
            {
                if (!wordToDelete.Contains(s))
                {
                    newLine.Append(s);
                }
            }
            return newLine.ToString();
        }
    }
}