using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise11
{
    /// <summary>
    /// 11. A string is given, composed of several "forbidden" words separated by commas. Also a text is given, containing those words.
    /// Write a program that replaces the forbidden words with asterisks.
    /// </summary>
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.";
            List<string> forbiddenTexts = new List<string> { "C#","CLR","Microsoft","wtf" };
            
            for(int i=0; i<forbiddenTexts.Count;i++)
            {
                text = text.Replace(forbiddenTexts[i], GetReplaceString(forbiddenTexts[i]));
            }
            Console.WriteLine(text);
            Console.ReadKey(true);
        }

        /// <summary>
        /// Replace string with "*" using StringBuilder 
        /// Can also use: string replaced = new string('*', inputStr.Length);
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        private static string GetReplaceString(string inputStr)
        {
            StringBuilder replaced = new StringBuilder();
            for(int i =0; i< inputStr.Length;i++)
            {
                replaced.Append("*");
            }
            return replaced.ToString();
        }
    }
}
