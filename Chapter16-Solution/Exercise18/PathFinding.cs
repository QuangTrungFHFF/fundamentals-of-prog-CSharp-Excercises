using System.Collections.Generic;

namespace Exercise18
{
    internal class PathFinding
    {
        public string[,] Matrix { get; set; }
        public Point StartPoint { get; set; }

        public PathFinding(string[,] matrix)
        {
            Matrix = matrix;
        }
        

        public string[,] MarkMatrix()
        {            
            //Using BFS to mark nodes
            Queue<Point> paths = new Queue<Point>();
            int distance = 0;
            FindStartPoint();
            Point currentPoint;
            List<Point> neighbors;
            paths.Enqueue(StartPoint);
            Matrix[StartPoint.X, StartPoint.Y] = "S";
            while (paths.Count > 0)
            {
                distance++;
                currentPoint = paths.Dequeue();
                if (Matrix[currentPoint.X, currentPoint.Y] != "S")
                {
                    Matrix[currentPoint.X, currentPoint.Y] = currentPoint.Distance.ToString();
                }

                neighbors = GetPassableNeighbors(currentPoint);
                foreach (Point p in neighbors)
                {
                    paths.Enqueue(p);
                }
            }
            //Find leftover (unreachable) node
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    if (Matrix[row, column].Equals("0"))
                    {
                        Matrix[row, column] = "u";
                    }
                }
            }
            return Matrix;
        }

        /// <summary>
        /// Find start point of the matrix
        /// </summary>
        public void FindStartPoint()
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    if (Matrix[row, column].Equals("a"))
                    {
                        StartPoint = new Point(row, column, 0);
                    }
                }
            }
        }
        

        /// <summary>
        /// Get all passable nodes near the current node
        /// </summary>
        /// <param name="currentPoint"></param>
        /// <returns></returns>
        public List<Point> GetPassableNeighbors(Point currentPoint)
        {
            var passablePoints = new List<Point>();
            Point nextPoint;
            if (this.CheckLeft(currentPoint))
            {
                nextPoint = new Point(currentPoint.X, currentPoint.Y - 1, currentPoint.Distance + 1);
                passablePoints.Add(nextPoint);
            }
            if (this.CheckRight(currentPoint))
            {
                nextPoint = new Point(currentPoint.X, currentPoint.Y + 1, currentPoint.Distance + 1);

                passablePoints.Add(nextPoint);
            }
            if (this.CheckUp(currentPoint))
            {
                nextPoint = new Point(currentPoint.X - 1, currentPoint.Y, currentPoint.Distance + 1);

                passablePoints.Add(nextPoint);
            }
            if (this.CheckDown(currentPoint))
            {
                nextPoint = new Point(currentPoint.X + 1, currentPoint.Y, currentPoint.Distance + 1);

                passablePoints.Add(nextPoint);
            }
            return passablePoints;
        }

        /// <summary>
        /// Check left node
        /// </summary>
        /// <param name="currentPoint"></param>
        /// <returns></returns>
        public bool CheckLeft(Point currentPoint)
        {
            if (currentPoint.Y == 0)
            {
                return false;
            }
            if (Matrix[currentPoint.X, (currentPoint.Y - 1)] == "0")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check right node
        /// </summary>
        /// <param name="currentPoint"></param>
        /// <returns></returns>
        public bool CheckRight(Point currentPoint)
        {
            if (currentPoint.Y == (Matrix.GetLength(1) - 1))
            {
                return false;
            }
            if (Matrix[currentPoint.X, (currentPoint.Y + 1)] == "0")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check node 1 line above
        /// </summary>
        /// <param name="currentPoint"></param>
        /// <returns></returns>
        public bool CheckUp(Point currentPoint)
        {
            if (currentPoint.X == 0)
            {
                return false;
            }
            if (Matrix[(currentPoint.X - 1), currentPoint.Y] == "0")
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Check node 1 line below
        /// </summary>
        /// <param name="currentPoint"></param>
        /// <returns></returns>
        public bool CheckDown(Point currentPoint)
        {
            if (currentPoint.X == (Matrix.GetLength(0) - 1))
            {
                return false;
            }
            if (Matrix[(currentPoint.X + 1), currentPoint.Y] == "0")
            {
                return true;
            }
            return false;
        }
    }
}