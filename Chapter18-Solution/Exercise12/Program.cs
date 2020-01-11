using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "11:23";
            Bus bus = new Bus("a","s");
            int b = bus.GetArrivalTime(a);
            Console.WriteLine(b);
        }
    }
}
