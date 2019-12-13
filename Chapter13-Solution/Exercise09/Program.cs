using System;
using System.Text;

namespace Exercise09
{
    /// <summary>
    /// Write a program that encrypts a text by applying XOR (excluding or) operation between the given source characters and given cipher code.
    /// The encryption should be done by applying XOR between the first letter of the text and the first letter of the code, the second letter
    /// of the text and the second letter of the code, etc. until the last letter of the code, then goes back to the first letter of the code
    /// and the next letter of the text. Print the result as a series of Unicode escape characters \xxxx.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder encryted = new StringBuilder();
            Console.WriteLine("Please enter a string!");
            char[] charArray = Console.ReadLine().ToCharArray();
            Console.WriteLine("Please enter the cipher code!");
            char[] cipherCode = Console.ReadLine().ToCharArray();
            int cipherPos = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                encryted.AppendFormat("\\u{0:x4}", (charArray[i] ^ cipherCode[cipherPos]));
                cipherPos++;
                //Reset the position of the code if max length is reached
                if (cipherPos >= cipherCode.Length)
                {
                    cipherPos = 0;
                }
            }
            Console.WriteLine(encryted);
        }
    }
}