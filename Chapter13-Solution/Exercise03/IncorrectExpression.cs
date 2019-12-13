using System;

namespace Exercise03
{
    /// <summary>
    /// 3. Write a program that checks whether the parentheses are placed correctly in an arithmetic expression.
    /// Example of expression with correctly placed brackets: ((a+b)/5-d). Example of an incorrect expression: )(a+b)).
    /// </summary>
    class IncorrectExpression
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter an arithmetic expression. ex: (a+b)/5-d).");
            bool checkExpression = CheckExpression(Console.ReadLine());
            Console.WriteLine(checkExpression);
        }

        /// <summary>
        /// Check if number of open brackets is equal to close brackets
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static bool CheckExpression(string expression)
        {
            int rightBracket = 0, leftBracket = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].Equals("("))
                {
                    leftBracket++;
                }
                if (expression[i].Equals(")"))
                {
                    rightBracket++;
                }
            }
            if (rightBracket != leftBracket)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}