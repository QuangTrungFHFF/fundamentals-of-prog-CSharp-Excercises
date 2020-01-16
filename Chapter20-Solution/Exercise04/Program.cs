using System;
using System.Collections.Generic;

namespace Exercise04
{
    /// <summary>
    /// Initialize an array of 10 workers and sort them by salary in descending order.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Mary", "Oma1", 2800,120));
            workers.Add(new Worker("Mary", "Oma2", 3600, 120));
            workers.Add(new Worker("Mary", "Oma3", 5800, 120));
            workers.Add(new Worker("Mary", "Oma4", 10000, 120));
            workers.Add(new Worker("Mary", "Oma5", 9800, 120));
            workers.Add(new Worker("Mary", "Oma6", 4200, 120));
            workers.Add(new Worker("Mary", "Oma7", 6900, 120));
            workers.Add(new Worker("Mary", "Oma8", 3600, 120));
            workers.Add(new Worker("Mary", "Oma9", 4100, 120));
            workers.Add(new Worker("Mary", "OmaX", 4300, 120));
            workers.Sort();
            foreach (var s in workers)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
