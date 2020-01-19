using System;

namespace Exercise14
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test!");
            //Create a new CircularQueueArray
            var testArray = new CircularQueueArray<int>();
            //Try DeQueue when array is empty
            Console.WriteLine(testArray.DeQueue());
            //Add new item to the queue
            testArray.Enqueue(250); 
            Console.WriteLine(testArray.DeQueue());
            testArray.Enqueue(300);
            Console.WriteLine(testArray.HeadIndex);
            testArray.Enqueue(400);
            testArray.Enqueue(500);           
            testArray.Enqueue(600);
            testArray.Enqueue(700);
            Console.WriteLine(testArray.Count);  
            //Add new item when queue is full
            testArray.Enqueue(800);
            Console.WriteLine(testArray.Count);
            //Try DeQueue after array has been resized
            Console.WriteLine(testArray.DeQueue());
            
            

        }
    }
}
