using System;

namespace Exercise14
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test!");
            var testArray = new CircularQueueArray<int>();
            Console.WriteLine(testArray.DeQueue());
            testArray.Enqueue(250); 
            Console.WriteLine(testArray.DeQueue());
            testArray.Enqueue(300);
            Console.WriteLine(testArray.HeadIndex);
            testArray.Enqueue(400);
            testArray.Enqueue(500);           
            testArray.Enqueue(600);
            testArray.Enqueue(700);
            Console.WriteLine(testArray.Count);            
            testArray.Enqueue(800);
            Console.WriteLine(testArray.Count);
            Console.WriteLine(testArray.DeQueue());
            
            

        }
    }
}
