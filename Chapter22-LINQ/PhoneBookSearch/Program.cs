using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PhoneBookSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBookGenerator kk = new PhoneBookGenerator();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var ex = kk.Generator(50000);
            stopwatch.Stop();
            Console.WriteLine($"{stopwatch.ElapsedMilliseconds/(double)1000} s");

            PrintDictionary(ex);

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
