using System;
using System.Globalization;

namespace Exercise20
{
    /// <summary>
    /// Write a program that extracts from a text all dates written in format DD.MM.YYYY and prints them on the console in the standard format for Canada. Sample text:
    /// </summary>
    internal class ExtractDate
    {
        private static void Main(string[] args)
        {
            string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
            string[] splitText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitText.Length; i++)
            {
                splitText[i] = splitText[i].TrimEnd('.', ')', '?', '!');
                if (DateTime.TryParseExact(splitText[i], "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    Console.WriteLine(splitText[i]);
                }
            }
            Console.ReadKey();
        }
    }
}