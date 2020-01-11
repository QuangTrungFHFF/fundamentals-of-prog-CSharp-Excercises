using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise12
{
    class Schedule
    {
        public HashSet<Bus> Buses { get; private set; }
        public int TotalBuses { get { return this.Buses.Count; } }
        public Schedule()
        {
            this.Buses = new HashSet<Bus>();
        }
        public void AddBus(string name, string arrivalTime, string depatureTime)
        {
            this.Buses.Add(new Bus(name,arrivalTime, depatureTime));                
        }
        public void GetBusInRange(string range)
        {
            var arrivalBuses = GetBusArrival(range);
            var departureBuses = GetBusDeparture(range);
            arrivalBuses.IntersectWith(departureBuses);
            Console.WriteLine("There are {0} buses that arrival and departure in the range {1}.", arrivalBuses.Count, range);
            foreach(Bus b in arrivalBuses)
            {
                Console.WriteLine(b.ToString());
            }

        }
        public HashSet<Bus> GetBusArrival(string r)
        {
            HashSet<Bus> arrival = new HashSet<Bus>();
            int[] range = GetRange(r);
            foreach(Bus b in this.Buses)
            {
                if(b.Arrival>= range[0]&&b.Arrival<=range[1])
                {
                    arrival.Add(b);
                }
            }
            return arrival;
        }
        public HashSet<Bus> GetBusDeparture(string r)
        {
            HashSet<Bus> departure = new HashSet<Bus>();
            int[] range = GetRange(r);
            foreach (Bus b in this.Buses)
            {
                if (b.Departure >= range[0] && b.Departure <= range[1])
                {
                    departure.Add(b);
                }
            }
            return departure;
        }
        public static int[] GetRange(string range)
        {
            int[] timeRange = new int[2];
            string min = range.Trim().Split('-',StringSplitOptions.RemoveEmptyEntries)[0];
            string max = range.Trim().Split('-', StringSplitOptions.RemoveEmptyEntries)[1];
            string pattern = @"^(0[0-9]|1[0-9]|2[0-3]|[0-9]):([0-5][0-9])$";
            if (!Regex.IsMatch(min,pattern)|| !Regex.IsMatch(max, pattern))
            {
                throw new FormatException("Incorrect time format!");
            }
            string[] time = min.Split(':', StringSplitOptions.RemoveEmptyEntries);
            timeRange[0] =  int.Parse(time[0]) * 100 + int.Parse(time[1]);
            time = max.Split(':', StringSplitOptions.RemoveEmptyEntries);
            timeRange[1] = int.Parse(time[0]) * 100 + int.Parse(time[1]);
            return timeRange;
        }
        
    }
}
