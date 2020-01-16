using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise05
{
    abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateSurface();
        
    }
}
