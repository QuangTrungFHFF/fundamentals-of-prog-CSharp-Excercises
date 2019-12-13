using System;
using System.Text;

namespace Chapter13_Solution
{
    /// <summary>
    /// 2. Write a program that reads a string, reverse it and prints it to the console. For example: "introduction"  "noitcudortni".
    /// </summary>
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string!");
            Console.WriteLine("The reversed string is: " + ReverseCurrentString(Console.ReadLine()));
            Console.ReadKey(true);
        }
        /// <summary>
        /// Reverse string by using Stringbuilder class
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private static string ReverseCurrentString(string inputString)
        {
            StringBuilder result = new StringBuilder();
            for(int i = (inputString.Length-1);i>=0;i--)
            {
                result.Append(inputString[i]);
            }
            return result.ToString();
        }
    }
}
