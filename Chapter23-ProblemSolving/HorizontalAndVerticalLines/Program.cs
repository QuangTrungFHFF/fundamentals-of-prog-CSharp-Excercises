using System;
namespace HorizontalAndVerticalLines
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var plane = new Plane();
            plane.AddPoint(1, 1);
            plane.AddPoint(1, 6);
            plane.AddPoint(4, 3);
            plane.AddPoint(6, 6);
            plane.AddPoint(6, 2);
            plane.AddPoint(8, 5);
            plane.AddPoint(9, 7);
            plane.AddPoint(10, 2);
            plane.AddPoint(11, 5);            
            plane.PrintAllPoints();
            //Test vertival line with 9 points (no possible line case)
            plane.FindAllVerticalLines();

            //Test vertival line with 10 points (many lines found case)
            plane.AddPoint(12, 1);
            plane.FindAllVerticalLines();

            //Test vertival line with 11 points (1 line through 1 point case)
            plane.AddPoint(7, 4);
            plane.FindAllVerticalLines();

            //Test vertival line with 12 points (1 line through many points case)
            plane.AddPoint(7, 7);
            plane.FindAllVerticalLines();

            
            
        }
    }
}