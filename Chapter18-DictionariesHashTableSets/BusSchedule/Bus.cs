﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise12
{
    class Bus
    {
        public int Arrival { get; private set; }
        public int Departure { get; private set; }
        public string Name { get; private set; }
        private string[] text =new string[2];
       
        public Bus(string name, string arrival, string departure)
        {
            this.Name = name;
            this.Arrival = GetArrivalTime(arrival);
            this.Departure = GetDepartureTime(departure);
            //this is for ToString method
            this.text[0] = arrival.Trim();
            this.text[1] = departure.Trim();
        }
        public override string ToString()
        {
            return string.Format("Bus {0}: Arrival: {1} Departure: {2}",this.Name,this.text[0],this.text[1]);
        }
        private int GetArrivalTime(string a)
        {
            a = a.Trim();
            if (!Regex.IsMatch(a,@"^(0[0-9]|1[0-9]|2[0-3]|[0-9]):([0-5][0-9])$"))
            {
                throw new FormatException("Incorrent time format!");
            }            
            string[] time = a.Split(':',StringSplitOptions.RemoveEmptyEntries);
            return int.Parse(time[0]) * 100 + int.Parse(time[1]); 
        }
        private int GetDepartureTime(string a)
        {
            a = a.Trim();
            if (!Regex.IsMatch(a, @"^(0[0-9]|1[0-9]|2[0-3]|[0-9]):([0-5][0-9])$"))
            {
                throw new FormatException("Incorrent time format!");
            }
            string[] time = a.Split(':');
            return int.Parse(time[0]) * 100 + int.Parse(time[1]);
        }

    }
}
