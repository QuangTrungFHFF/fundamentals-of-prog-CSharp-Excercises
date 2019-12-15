using System;

namespace Exercise18
{
    /// <summary>
    /// Write a program that reads the date and time entered in the format "day.month.year hour:minutes:seconds" and prints the date and time after 6 hours and 30 minutes in the same format.
    /// </summary>
    internal class After630
    {
        private static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            TimeSpan interval = new TimeSpan(6, 30, 0);
            Console.WriteLine("Please enter a date and time!");
            if (DateTime.TryParse(Console.ReadLine(), out dateTime))
            {
                Console.WriteLine("After {0} hours {1} minutes, the new time is: {2}", interval.Hours, interval.Minutes, dateTime + interval);
            }
            else
            {
                Console.WriteLine("Invalid format. Try again with dd.mm.yyyy hh:mm:ff.");
            }
            Console.ReadKey(true);
        }
    }
}