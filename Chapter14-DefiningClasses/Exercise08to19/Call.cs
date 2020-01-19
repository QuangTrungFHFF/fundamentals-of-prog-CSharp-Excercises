using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
/// <summary>
/// Create a class Call, which contains information about a call made via mobile phone. It should contain information about date, time of start and duration of the call.
/// </summary>
namespace Exercise08to19
{
    class Call : IComparable<Call>
    {
        private DateTime callTime = new DateTime();
        private TimeSpan duration = new TimeSpan();
        

        public Call(DateTime callTime, int duration)
        {
            this.callTime = callTime;
            this.duration = new TimeSpan(0, duration,0);
        }
        public override string ToString()
        {
            return string.Format("Start time: {0}, Duration: {1} minute(s)", CallTime, DurationMinutes);
        }

        public int CompareTo([AllowNull] Call that)
        {
            return this.DurationMinutes.CompareTo(that.DurationMinutes);
        }

        public DateTime CallTime
        {
            get { return this.callTime; }
            set { this.callTime = value; }
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
