using System;

namespace Exercise10
{
    /// <summary>
    /// Write a program that extracts from a text all sentences that contain a particular word. 
    /// We accept that the sentences are separated from each other by the character "." and the words are separated from one another by a character which is not a letter.
    /// </summary>
    internal class ParticularWord
    {
        private static void Main(string[] args)
        {
            string shortText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine().Trim();
            word = " " + word + " ";
            string[] sentences = shortText.Split('.');
            for(int i=0;i<sentences.Length;i++)
            {
                if(sentences[i].IndexOf(word)!=-1)
                {
                    Console.WriteLine(sentences[i].Trim()+".");
                }
            }
            Console.ReadKey(true);
        }
    }
}