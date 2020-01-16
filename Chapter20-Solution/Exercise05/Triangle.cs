using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise05
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }
}
