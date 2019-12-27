using System;
using System.Text.RegularExpressions;

namespace Exercise26
{
    /// <summary>
    /// Write a program that extracts all the text without any tags and attribute values from an HTML document.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string result = String.Empty;
            string text = "<html>< head >< title > News </ title ></ head >< body >< p >< a href = \"http://softuni.org\" > Software University </ a > aims to provide free real-world practical"
                + "training for young people who want to turn into skillful software engineers.</ p ></ body ></ html > ";
            
            Regex regex = new Regex(@">(?<word>.*?)<"); 
            MatchCollection word = regex.Matches(text);
            foreach(Match m in word)
            {
                if((result = m.Groups[1].Value)!="")
                {
                    Console.WriteLine(result);
                }
                
            }




        }
    }
}
