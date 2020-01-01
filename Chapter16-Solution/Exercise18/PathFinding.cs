using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise18
{
    class PathFinding
    {
        public HashSet<Point> markedPoints = new HashSet<Point>();
        public HashSet<Point> MarkedPoint
        {
            get { return markedPoints; }
        }  
        public string[,] Matrix { get; set; }
        public Point StartPoint { get; set; }
        public PathFinding(string[,] matrix)
        {
            Matrix = matrix;
        }
        public string[,] MarkMatrix()
        {
            string[,] matrix = Matrix;
            Queue<Point> paths = new Queue<Point>();
            int count = 0;
            FindStartPoint();
            Point currentPoint = StartPoint;
            List<Point> neighbors;
            paths.Enqueue(StartPoint);
            Console.WriteLine(StartPoint.X);
            Console.WriteLine(StartPoint.Y);
            markedPoints.Add(new Point(StartPoint.X, StartPoint.Y));
            
            while(paths.Count>0)
            {
                currentPoint = paths.Dequeue();
                matrix[currentPoint.X, currentPoint.Y] = "e";
                Console.WriteLine(Matrix[currentPoint.X, currentPoint.Y]);
                neighbors = GetPassableNeighbors(currentPoint);
                foreach(Point p in neighbors)
                {
                    paths.Enqueue(p);
                    markedPoints.Add(p); 
                }
            }
            return matrix;


        }
        public void FindStartPoint()
        {
             
            for(int row = 0; row < Matrix.GetLength(0);row++)
            {
                for(int column = 0; column<Matrix.GetLength(1);column++)
                {
                    if(Matrix[row,column].Equals("a"))
                    {
                        StartPoint = new Point(row, column);                        
                    }
                }
            }
            
            
        }
        public List<Point> GetPassableNeighbors(Point currentPoint)
        {
            var passablePoints = new List<Point>();
            if(this.CheckLeft(currentPoint))
            {
                passablePoints.Add(new Point(currentPoint.X,currentPoint.Y -1));
            }
            if (this.CheckRight(currentPoint))
            {
                passablePoints.Add(new Point(currentPoint.X, currentPoint.Y + 1));
            }
            if (this.CheckUp(currentPoint))
            {
                passablePoints.Add(new Point(currentPoint.X-1, currentPoint.Y));
            }
            if (this.CheckDown(currentPoint))
            {
                passablePoints.Add(new Point(currentPoint.X + 1, currentPoint.Y));
            }
            return passablePoints;
        }
        public bool CheckLeft(Point currentPoint)
        {
            if(currentPoint.Y==0)
            {
                return false;
            }
            if(Matrix[currentPoint.X,(currentPoint.Y-1)]=="x")
            {
                return false;
            }
            if(markedPoints.Contains(currentPoint))
            {
                return false;
            }

            return true;
        }
        public bool CheckRight(Point currentPoint)
        {
            if (currentPoint.Y == (Matrix.GetLength(1)-1))
            {
                return false;
            }
            if (Matrix[currentPoint.X, (currentPoint.Y + 1)] == "x")
            {
                return false;
            }
            if (markedPoints.Contains(currentPoint))
            {
                return false;
            }
            return true;
        }
        public bool CheckUp(Point currentPoint)
        {
            if (currentPoint.X == 0)
            {
                return false;
            }
            if (Matrix[(currentPoint.X-1), currentPoint.Y] == "x")
            {
                return false;
            }
            if (markedPoints.Contains(currentPoint))
            {
                return false;
            }
            return true;
        }
        public bool CheckDown(Point currentPoint)
        {
            if (currentPoint.X == (Matrix.GetLength(0) - 1))
            {
                return false;
            }
            if (Matrix[(currentPoint.X+1),currentPoint.Y] == "x")
            {
                return false;
            }
            if (markedPoints.Contains(currentPoint))
            {
                return false;
            }
            return true;
        }


    }
}
