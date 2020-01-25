using System;

namespace HorizontalAndVerticalLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointA = new Point(4, 6);
            var pointB = new Point(4, 6);
            Console.WriteLine(pointA);
            Console.WriteLine(pointA.Equals(pointB));
        }
    }
}
