using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PhoneBookSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneBookGenerator generator = new PhoneBookGenerator();            
            var phoneBook = generator.Generator(500000);

            //Test speed using Contains
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool isFound = phoneBook.ContainsKey("Junita Giese");            
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} milliseconds");
            stopwatch.Reset();

            stopwatch.Start();
            var y = from people in phoneBook
                    where people.Key.Equals("Junita Giese")
                    select people;
            stopwatch.Stop();            
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds} milliseconds");
            Console.WriteLine(isFound);

            //PrintDictionary(ex);

        }
        public static void PrintDictionary(Dictionary<string,string> phoneBook)
        {
            foreach(var p in phoneBook)
            {
                Console.WriteLine($"{p.Key.PadRight(25)} - {p.Value}");
            }
        }

    }
}
