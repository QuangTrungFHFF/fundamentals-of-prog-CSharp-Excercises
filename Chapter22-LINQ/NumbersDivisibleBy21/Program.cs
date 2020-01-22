using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersDivisibleBy21
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {21,5,2,369,854,785,23,65,4,125,14,5,78,96,32,1,42,54,63 };
            var findWithLambda = numbers.FindAll(x => x % 21 == 0);
            var findWithLinq = from number in numbers
                               where number % 21 == 0
                               select number;

            Console.WriteLine("Numbers found with lambda: ");
            foreach(var i in findWithLambda)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Numbers found with linq: ");
            foreach (var i in findWithLinq)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

        }
    }
}
