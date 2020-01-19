using System;
using Exercise25;

namespace Exercise26
{
    /// <summary>
    /// Write a class FractionTest, which tests the functionality of the class Fraction from previous task. Pay close attention on testing the function Parse with different input data.
    /// </summary>
    class FractionTest
    {
        static void Main(string[] args)
        {
            //Create new Fraction
            Fraction x = new Fraction(-2, 3);
            //Test ToString() method
            Console.WriteLine(x.ToString());
            //Test Parse function
            Console.WriteLine("Please enter a fraction!");
            Fraction y =Fraction.Parse(Console.ReadLine());
            Console.WriteLine(y.ToString());
            y = Fraction.Parse("0/5");
            Console.WriteLine(y.ToString());
            y = Fraction.Parse("0/-5");
            Console.WriteLine(y.ToString());
            //Test Fraction Value
            y = Fraction.Parse("1 / 4");
            Console.WriteLine(y.FractionValue);
        }
    }
}
