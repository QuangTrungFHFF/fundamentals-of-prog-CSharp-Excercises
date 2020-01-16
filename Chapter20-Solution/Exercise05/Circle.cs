using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise05
{
    class Circle:Shape
    {
        public double Radius { get { return this.Height; } }
        public Circle(double radius)
        {
            this.Height = radius;
            this.Width = radius;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width * Math.PI;
        }
    }
}
