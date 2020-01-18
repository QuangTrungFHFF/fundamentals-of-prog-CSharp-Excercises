using System;

namespace Exercise05
{
    /// <summary>
    /// 5. Write a program that detects how many times a substring is contained in the text.
    /// </summary>
    internal class SubstringCounter
    {
        private static void Main(string[] args)
        {
            string shortText = "We are living in a yellow submarine. We don't have anything else. " +
            "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            shortText = shortText.ToLower();
            string keyword = "in";
            int count = 0;
            int index = shortText.IndexOf(keyword);
            while (index != -1)
            {
                count++;
                index = shortText.IndexOf(keyword, index + 1);
            }
            Console.WriteLine("There are {0} occurances of keyword \"{1}\" in the given text.", count, keyword);
            Console.ReadKey(true);
        }
    }
}