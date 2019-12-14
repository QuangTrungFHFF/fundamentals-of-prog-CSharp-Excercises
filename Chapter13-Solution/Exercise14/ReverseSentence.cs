using System;

namespace Exercise14
{
    /// <summary>
    /// Write a program that reverses the words in a given sentence without changing punctuation and spaces.
    /// For example: "C# is not C++ and PHP is not Delphi"  "Delphi not is PHP and C++ not is C#".
    /// </summary>
    internal class ReverseSentence
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence!");
            string sentence = Console.ReadLine();
            string[] reverse = sentence.Split(' ');
            Console.WriteLine("Press any key to reverse the sentence!");
            Console.ReadKey(false);
            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                Console.Write(reverse[i] + " ");
            }
        }
    }
}