using System;
using System.Text;

namespace Exercise07
{
    /// <summary>
    /// Write a program that reads a string from the console (20 characters maximum) and if shorter complements it right with "*" to 20 characters.
    /// </summary>
    internal class StringOf20Characters
    {
        private static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Please enter a string < 20 characters");
            str = Console.ReadLine();
            if (str.Length > 20)
            {
                Console.WriteLine("Your input string has more than 20 characters!");
            }
            else
            {
                StringBuilder result = new StringBuilder();
                result.Append(str);
                for (int i = str.Length; i < 20; i++)
                {
                    result.Append("*");
                }
                Console.WriteLine(result);
            }
        }
    }
}