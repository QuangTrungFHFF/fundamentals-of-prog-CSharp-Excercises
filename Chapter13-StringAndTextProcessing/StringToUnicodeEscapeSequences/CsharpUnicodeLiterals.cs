using System;
using System.Linq;

namespace Exercise08
{
    /// <summary>
    /// Write a program that converts a given string into the form of array of Unicode escape sequences in the format used in the C# language. 
    /// Sample input: "Test". Result: "\u0054\u0065\u0073\u0074".
    /// </summary>
    internal class CsharpUnicodeLiterals
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string str = Console.ReadLine();

            var result = str.Select(t => $"\\u{Convert.ToInt16(t):X4}").ToList();

            foreach (string s in result)
            {
                Console.Write(s);
            }
        }
    }
}