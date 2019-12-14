using System;

namespace Exercise17
{
    /// <summary>
    /// Write a program that reads two dates entered in the format "day.month.year" and calculates the number of days between them.
    /// </summary>
    internal class DaysCalculator
    {
        private static void Main(string[] args)
        {
            var firstDay = new DateTime();
            var secondDay = new DateTime();
            Console.WriteLine("Please enter the first day!");
            firstDay = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Please enter the second day!");
            secondDay = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            var result = Math.Abs((secondDay - firstDay).Days);
            Console.WriteLine("Between {0:dd/mm/yyyy} and {1:dd/mm/yyyy} are: {2} days.", firstDay, secondDay, result);
        }
    }
}