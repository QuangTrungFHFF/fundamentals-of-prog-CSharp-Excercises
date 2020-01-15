using System;

namespace Exercise06
{
    /// <summary>
    /// A timetable of a conference hall is a list of events in a format [starting date and time; ending date and time; event’s name]. 
    /// What data structure could we to be able to quickly add events and quickly check whether the hall is available in a given interval [starting date and time; ending date and time]?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var hall = new TimeTable();
            hall.Add("Event A", new DateTime(2020, 1, 10, 9, 0, 0), new DateTime(2020, 1, 15, 9, 0, 0));
            hall.Add("Event B", new DateTime(2020, 2, 7, 9, 0, 0), new DateTime(2020, 2, 15, 9, 0, 0));
            hall.Add("Event C", new DateTime(2020, 3, 5, 9, 0, 0), new DateTime(2020, 3, 15, 9, 0, 0));
            hall.Add("Event D", new DateTime(2020, 4, 15, 9, 0, 0), new DateTime(2020, 5, 7, 9, 0, 0));
            hall.Add("Event E", new DateTime(2020, 5, 20, 9, 0, 0), new DateTime(2020, 5, 28, 9, 0, 0));
            hall.Add("Event F", new DateTime(2020, 6, 14, 9, 0, 0), new DateTime(2020, 6, 15, 9, 0, 0));
            hall.Add("Event G", new DateTime(2020, 7, 29, 9, 0, 0), new DateTime(2020, 9, 14, 9, 0, 0));
            hall.PrintTimeTable();
            Console.WriteLine("");
            hall.CheckAvailable(new DateTime(2020, 2, 16, 9, 0, 0), new DateTime(2020, 3, 4, 9, 0, 0));
            hall.CheckAvailable(new DateTime(2020, 4, 18, 9, 0, 0), new DateTime(2020, 5, 4, 9, 0, 0));
        }
    }
}
