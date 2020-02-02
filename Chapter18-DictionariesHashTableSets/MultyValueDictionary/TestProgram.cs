using System;
using System.Collections.Generic;

namespace Exercise06
{
    /// <summary>
    /// Implement a hash-table, allowing the maintenance of more than one value for a specific key.
    /// </summary>
    class TestProgram
    {
        static void Main(string[] args)
        {
            //Create a multy values dictionary
            var dictionary = new MultyValueDictionary<string, string>("Barack Obama", "President", "Writer", "Artist");
            Console.WriteLine("There are {0} people on the list.",dictionary.Count);
            //Add new key with multiple values to the dictionary
            dictionary.Add("Bill Gates", "Inventor", "Adviser", "Entrepreneur", "Software Developer");
            Console.WriteLine("Barack Obama: ");
            foreach(var item in dictionary["Barack Obama"])
            {
                Console.Write(item + " / ");
            }
            Console.WriteLine("\nBill Gates: ");
            foreach (var item in dictionary["Bill Gates"])
            {
                Console.Write(item + " / ");
            }
            //Try Remove function
            dictionary.Remove("Barack Obama");
            //TryGetValues function
            List<string> items; 
            if(dictionary.TryGetValues("Barack Obama",out items))
            {
                foreach (var item in items)
                {
                    Console.Write(item + " / ");
                }
            }
            else
            {
                Console.WriteLine("\nNot found!");
            }

            if (dictionary.TryGetValues("Bill Gates", out items))
            {
                
                foreach (var item in items)
                {
                    Console.Write(item + " / ");
                }
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}
