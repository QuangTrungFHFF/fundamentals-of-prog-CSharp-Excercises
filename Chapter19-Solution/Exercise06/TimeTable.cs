using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise06
{
    class TimeTable
    {
        private SortedSet<Event> Events;
        public int Count { get { return this.Events.Count; } }
        public TimeTable()
        {
            this.Events = new SortedSet<Event>();
        }
        public void Add(Event newEvent)
        {
            if(Events.Contains(newEvent))
            {
                Console.WriteLine("Event already on the timetable!");
                return;
            }
            this.Events.Add(newEvent);
        }
        public void CheckAvailable(DateTime start, DateTime end)
        {
            if(IsAvailable(start, end))
            {
                Console.WriteLine("Hall is available between: {0} --- {1}", start.ToShortDateString(), end.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Hall is not available between: {0} --- {1}", start.ToShortDateString(), end.ToShortDateString());
            }
        }
        public bool IsAvailable(DateTime start,DateTime end)
        {
            foreach (var e in this.Events)
            {
                if (e.StartDate < end && e.EndDate > start)
                {
                    return false;
                }
            }
            return true;
        }
        
        public void Add(string name, DateTime start, DateTime end)
        {
            var newEvent = new Event(name, start, end);
            if (Events.Contains(newEvent))
            {
                Console.WriteLine("Event already on the timetable!");
                return;
            }
            this.Events.Add(newEvent);
        }
        public void Remove(Event @event)
        {
            if (!Events.Contains(@event))
            {
                Console.WriteLine("Cannot find the event on the timetable!");
                return;
            }
            this.Events.Remove(@event);
        }
        public void Clear()
        {
            this.Events = new SortedSet<Event>();
        }
        public void PrintTimeTable()
        {
            foreach(var e in this.Events)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
