using System;
using System.Collections.Generic;
using System.Text;

namespace HorizontalAndVerticalLines
{
    class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override bool Equals(object obj)
        {
            var that = (Point)obj;
            bool isEqual = (this.X.Equals(that.X)) && (this.Y.Equals(that.Y));
            return isEqual ;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 0;
                hash += (hash * 397) ^ this.X.GetHashCode();
                hash += (hash * 397) ^ this.Y.GetHashCode();
                return hash;
            }
        }
        public override string ToString()
        {
            return string.Format($"({this.X}, {this.Y})");
        }
    }
}
