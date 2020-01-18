using System;

namespace Exercise22
{
    class CharacterCount
    {
        /// <summary>
        /// Write a program that reads a string from the console and prints in alphabetical order all words from the input string and how many times each one of them occurs in the string.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string!");
            char[] text = Console.ReadLine().Replace(" ","").ToLower().ToCharArray();
            Array.Sort(text);
            Console.WriteLine(text);
            CountChar(text);



        }
        private static void CountChar(char[] charArray)
        {
            int count = 1;
            for(int i =0; i<charArray.Length-1;i++)
            {
                if(charArray[i].Equals(charArray[i+1]))
                {
                    count += 1;
                }
                else
                {
                    Console.WriteLine("Char {0}: {1}", charArray[i], count);
                    count = 1;
                }
            }
            Console.WriteLine("Char {0}: {1}", charArray[charArray.Length-1], count);

        }
    }
}
