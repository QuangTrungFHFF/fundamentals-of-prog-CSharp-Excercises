using System;
using System.Text.RegularExpressions;

namespace Exercise19
{
    /// <summary>
    /// Write a program that extracts all e-mail addresses from a text. 
    /// These are all substrings that are limited on both sides by text end or separator between words and match the shape <sender>@<host>…<domain>.
    /// </summary>
    internal class EmailFilter
    {
        private static void Main(string[] args)
        {
            string text = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk . This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
            string[] splitedText = text.Split(' ');
            CheckEmail(splitedText);
            Console.WriteLine("End!");
        }

        private static void CheckEmail(string[] str)
        {
            Regex filter = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            for (int i = 0; i < str.Length; i++)
            {
                if (filter.IsMatch(str[i]))
                {
                    Console.WriteLine(str[i]);
                }
            }
        }
    }
}