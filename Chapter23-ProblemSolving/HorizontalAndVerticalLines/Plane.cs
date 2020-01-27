using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HorizontalAndVerticalLines
{
    class Plane
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
            if(this.Points.Contains(point))
            {
                this.Points.Remove(point);
            }
        }
        private List<Point> SortPointsByX()
        {
            var points = this.Points.OrderBy(x => x.X).ToList();
            return points;
        }
        public void PrintAllPoints()
        {
            foreach(var p in this.Points)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
