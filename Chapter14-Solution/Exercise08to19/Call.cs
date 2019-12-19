using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Create a class Call, which contains information about a call made via mobile phone. It should contain information about date, time of start and duration of the call.
/// </summary>
namespace Exercise08to19
{
    class Call
    {
        private DateTime startTime = new DateTime();
        private TimeSpan duration = new TimeSpan();
        private DateTime callTime;

        public Call(DateTime callTime, int duration)
        {
            this.callTime = callTime;
            this.duration = new TimeSpan(0,0,duration);
        }

        public DateTime StartTime
        {
            get { return this.startTime; }
            set { this.startTime = value; }
        }
        public TimeSpan Duration
        {
            get { return duration; }
            set { this.duration = value; }

        }
        public double DurationMinutes
        {
            get { return this.duration.TotalMinutes; }            
        }
    }
}
