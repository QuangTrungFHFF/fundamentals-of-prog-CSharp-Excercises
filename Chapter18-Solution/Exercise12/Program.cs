using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            var schedule = new Schedule();
            schedule.AddBus("Bus 1", "08:24", "08:33");
            schedule.AddBus("Bus 2", "08:20", "09:00");
            schedule.AddBus("Bus 3", "08:32", "08:37");
            schedule.AddBus("Bus 4", "09:00", "09:15");
            string range = "08:22-09:05";
            schedule.GetBusInRange(range);



        }
    }
}
