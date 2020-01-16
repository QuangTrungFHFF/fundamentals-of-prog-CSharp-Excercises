using System;
using System.Collections.Generic;

namespace Exercise05
{
    /// <summary>
    /// Define an abstract class Shape with abstract method CalculateSurface() and fields width and height.
    /// Define two additional classes for a triangle and a rectangle, which implement CalculateSurface().
    /// This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2).
    /// Define a class for a circle with an appropriate constructor, which initializes the two fields (height and width)
    /// with the same value (the radius) and implement the abstract method for calculating the area.
    /// Create an array of different shapes and calculate the area of each shape in another array.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();
            list.Add(new Triangle(5, 4));
            list.Add(new Rectangle(5, 4));
            list.Add(new Circle(10));

            var area = new List<double>();
            foreach(var shape in list)
            {
                area.Add(shape.CalculateSurface());
            }

            foreach (var a in area)
            {
                Console.WriteLine($"{a:N2}");
            }

        }
    }
}
