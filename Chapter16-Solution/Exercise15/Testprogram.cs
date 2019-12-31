using System;
using System.Collections.Generic;

namespace Exercise15
{
    /// <summary>
    /// Implement numbers sorting in a dynamic linked list without using an additional array or other data structure.
    /// </summary>
    class Testprogram
    {
        static void Main(string[] args)
        {
            double[] data = { 0.52, 1.635, 5, 4, 8, 9, 6, 3, 145, 15.25, 5.36 };
            var doubleList = new LinkedList<double>(data);
            doubleList.BubbleSort();
            foreach(double d in doubleList)
            {
                Console.Write(d + " ");
            }
            
        }        
        
    }
}
