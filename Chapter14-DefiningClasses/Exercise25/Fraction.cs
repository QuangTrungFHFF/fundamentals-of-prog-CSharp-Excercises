using System;

namespace Exercise25
{
    /// <summary>
    /// Define a class Fraction, which contains information about the rational fraction (e.g. ¼ or ½). 
    ///  Define a static method Parse() to create a fraction from a sting (for example -3/4). Define the appropriate properties and constructors of the class. 
    /// Also write property of type Decimal to return the decimal value of the fraction(e.g. 0.25).
    /// </summary>
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public decimal FractionValue
        {
            get { return (decimal)Numerator/Denominator; }
        }
        public Fraction(int number)
        {
            Set(number, 1);
        }
        public Fraction(int numerator, int denominator)
        {
            Set(numerator, denominator);
        }
        public override string ToString()
        {
            return string.Format($"{Numerator}/{Denominator}");
        }
        /// <summary>
        /// Set numerator and denominator
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        public void Set(int numerator, int denominator)
        {
            if(denominator ==0)
            {
                throw new ArithmeticException("Denominator must not be 0!");
            }
            else
            {
                Numerator = numerator;
                Denominator = denominator;
            }
        }
        /// <summary>
        /// Parse string input to Fraction
        /// </summary>
        /// <param name="stringFraction"></param>
        public static Fraction Parse(string stringFraction)
        {
            int numerator;
            int denominator;
            if (stringFraction.IndexOf('/')<1)
            {
                throw new FormatException("Wrong format of fraction!");
            }
            string[] stringFractionArray = stringFraction.Trim().Split('/',' ',StringSplitOptions.RemoveEmptyEntries);

            if (stringFractionArray.Length > 2)
            {
                throw new FormatException("Wrong format of fraction!");
            }

            if (int.TryParse(stringFractionArray[0],out numerator)&&int.TryParse(stringFractionArray[1],out denominator))
            {
                return new Fraction(numerator, denominator);
            }
            else
            {
                throw new FormatException("Wrong format of fraction! Numerator and denominator must be both interger number!");
            }
        }
    }
}
