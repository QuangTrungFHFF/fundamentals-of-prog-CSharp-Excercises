using System;

namespace Exercise06
{
    internal class Event : IComparable
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Name { get; private set; }

        public Event(string name, DateTime start, DateTime end)
        {
            this.Name = name;
            this.StartDate = start;
            this.EndDate = end;
        }

        public Event(DateTime start, DateTime end) : this("Unknown", start, end)
        {
        }
        public override string ToString()
        {
            return string.Format("Name: {0} | Start Date: {1} ---  End Date: {2}", this.Name.PadRight(12),this.StartDate.ToShortDateString().PadRight(12),this.EndDate.ToShortDateString().PadRight(12));
        }

        public int CompareTo(object obj)
        {
            var that = (Event)obj;
            if(this.StartDate.CompareTo(that.StartDate) ==0)
            {
                if(this.Name.CompareTo(that.Name) == 0)
                {
                    return this.EndDate.CompareTo(that.EndDate);
                }
                return this.Name.CompareTo(that.Name);
            }
            return this.StartDate.CompareTo(that.StartDate);
        }
    }
}