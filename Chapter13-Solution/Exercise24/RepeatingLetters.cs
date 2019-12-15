using System;
using System.Text;

namespace Exercise24
{
    /// <summary>
    /// Write a program that reads a string from the console and replaces every sequence of identical letters in it with a single letter (the repeating letter).
    /// Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
    /// </summary>
    internal class RepeatingLetters
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string!");
            string text = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(text[0]);
            for(int i=1;i<text.Length;i++)
            {
                if(!text[i].Equals(text[i-1]))
                {
                    stringBuilder.Append(text[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}