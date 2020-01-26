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

            var plane = new Plane();
            plane.AddPoint(4, 6);
            plane.AddPoint(4,6);
            plane.PrintAllPoints();
            plane.RemovePoint(4, 6);
            plane.PrintAllPoints();
        }
    }
}
