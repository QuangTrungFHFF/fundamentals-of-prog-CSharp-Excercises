using System;

namespace Exercise27
{
    /// <summary>
    /// Write a function to cancel a fraction (e.g. if numerator and denominator are respectively 10 and 15, fraction to be cancelled to 2/3).
    /// </summary>
    class FractionCancel
    {
        static void Main(string[] args)
        {
            //Test
            Fraction x = new Fraction(-20, 30);
            x = Fraction.FractionCancel(x);
            Console.WriteLine(x.ToString());
            x = new Fraction(0, 30);
            x = Fraction.FractionCancel(x);
            Console.WriteLine(x.ToString());
        }
    }
}
