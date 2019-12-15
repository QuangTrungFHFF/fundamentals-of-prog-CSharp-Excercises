using System;

namespace Exercise21
{
    /// <summary>
    /// Write a program that extracts from a text all words which are palindromes, such as ABBA", "lamal", "exe".
    /// </summary>
    internal class Palindromes
    {
        private static void Main(string[] args)
        {
            string randomText = "The most familiar palindromes in English are character-unit palindromes."
                + "The characters read the same backward as forward. Some examples of palindromic words are redivider, "
                + "deified, civic, radar, level, rotor, kayak, reviver, Racecar, redder, madam, and refer.";
            Console.WriteLine(randomText);
            Console.WriteLine("---------List of palindromes in the above string---------");
            string[] text = randomText.Split(' ', '.', ',', '?', '!');
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(ReverseWord(text[i]), StringComparison.OrdinalIgnoreCase)&&text[i].Length>2)
                {
                    Console.WriteLine(text[i]);
                }
            }
        }

        /// <summary>
        /// Reverse the word
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string ReverseWord(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}