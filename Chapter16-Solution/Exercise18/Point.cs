using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise18
{
    class Point 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Distance { get; set; }
        public Point(int x, int y,int distance)
        {
            X = x;
            Y = y;
            Distance = distance;
        }
        
    }
}
