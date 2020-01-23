using System;
using System.Globalization;
using System.Threading;

namespace StringCapitalization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = "i absolutely will not back down!";
            Console.WriteLine(text.Capitalize());
        }
    }

    public static class StringExtension
    {
        public static string Capitalize(this string text)
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            TextInfo info = culture.TextInfo;
            string capitalized = info.ToTitleCase(text);
            return capitalized;
        }
    }
}