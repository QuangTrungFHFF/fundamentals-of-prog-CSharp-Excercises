using System;
using System.Collections.Generic;
using System.Linq;

namespace HorizontalAndVerticalLines
{
    internal class Plane
    {
        public HashSet<Point> Points { get; private set; }

        public Plane()
        {
            this.Points = new HashSet<Point>();
        }

        public void AddPoint(int x, int y)
        {
            this.Points.Add(new Point(x, y));
        }

        public void RemovePoint(int x, int y)
        {
            var point = new Point(x, y);
            if (this.Points.Contains(point))
            {
                this.Points.Remove(point);
            }
        }

        /// <summary>
        /// Find all vertical lines which split the plane into two parts,
        /// each containing equal set of points.
        /// </summary>
        public void FindAllVerticalLines()
        {
            if (this.Points.Count < 2)
            {
                Console.WriteLine("No line was found!");
                return;
            }
            var points = this.GetSortedListX();
            int middle = points.Count / 2;
            if (points.Count % 2 == 0)
            {
                if (points[middle] == points[middle-1])
                {
                    if(CheckBalance(points,middle))
                    {
                        Console.WriteLine($"Found line x = {points[middle]}");                        
                    }
                    else
                    {
                        Console.WriteLine("No line was found!");
                    }
                    return;
                }
                else
                {
                    Console.WriteLine($"All vertical lines between x = {points[middle-1]} and x = {points[middle]}");
                    return;
                }
            }
            else
            {

            }
        }

        private List<int> GetSortedListX()
        {
            var points = this.Points.OrderBy(p => p.X).ToList();
            var result = new List<int>();
            for (int i = 0; i < points.Count; i++)
            {
                result.Add(points[i].X);
            }
            return result;
        }

        private List<int> GetSortedListY()
        {
            var points = this.Points.OrderBy(p => p.Y).ToList();
            var result = new List<int>();
            for (int i = 0; i < points.Count; i++)
            {
                result.Add(points[i].Y);
            }
            return result;
        }
        private bool CheckBalance(List<int> points, int middle)
        {
            int countLeft = 0;
            for(int i =0;i<middle;i++)
            {
                if(points[i]!=points[middle])
                {
                    countLeft++;
                }
            }

            int countRight = 0;
            for (int i = points.Count-1; i > middle; i--)
            {
                if (points[i] != points[middle])
                {
                    countRight++;
                }
            }

            bool isBalance = countLeft == countRight;
            return isBalance ;
        }

        private int CountPointsOnLine(List<int> points, int coordinate)
        {
            int count = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i] == coordinate)
                {
                    count++;
                }
            }
            return count;
        }

        public void PrintAllPoints()
        {
            foreach (var p in this.Points)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}