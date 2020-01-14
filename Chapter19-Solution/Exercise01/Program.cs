using System;
using System.Collections.Generic;

namespace Exercise01
{
    /// <summary>
    /// Hash-tables do not allow storing more than one value in a key.
    /// How can we get around this restriction? Define a class to hold multiple values in a hash-table.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash-Table with multy value.");
            var dictionary = new Dictionary<string, ValuesHolder<string>>();
            dictionary.Add("Mary", new ValuesHolder<string>("01524 9658745", "01522 6855874", "01632 9632154", "01782 1455214"));
            dictionary.Add("Peter", new ValuesHolder<string>("01584 5858745", "01522 6895474", "01247 9856325", "01712 8745854"));
            dictionary["Mary"].Add("01254 2541254");
            foreach(var student in dictionary)
            {
                Console.WriteLine("Name: " + student.Key);
                foreach(var phoneNumber in student.Value)
                {
                    Console.WriteLine("      {0}", phoneNumber);
                }
            }
        }
    }
}
