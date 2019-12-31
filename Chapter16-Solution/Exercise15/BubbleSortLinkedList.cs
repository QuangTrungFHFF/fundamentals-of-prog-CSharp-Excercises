using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise15
{
    public static class BubbleSortLinkedList
    {
        // This is the extension method.
        // The first parameter takes the "this" modifier
        // and specifies the type for which the method is defined.
        public static LinkedList<double> BubbleSort(this LinkedList<double> linkedList)
        {
            if(linkedList == null||linkedList.Count ==1)
            {
                Console.WriteLine("Nothing to sort!");                
            }
            else
            {
                //Scan from beginning of the list, if current node > next node then swap them. 
                //Loop the scan process until the loop without any swap
                bool isSwapFree = false;
                while(!isSwapFree)
                {
                    isSwapFree = true;
                    for(LinkedListNode<double> currentNode = linkedList.First;currentNode.Next!=null;currentNode = currentNode.Next)
                    {
                        if(currentNode.Value>currentNode.Next.Value)
                        {
                            double tempValue = currentNode.Value;
                            currentNode.Value = currentNode.Next.Value;
                            currentNode.Next.Value = tempValue;
                            isSwapFree = false;
                        }
                    }
                }                
            }
            return linkedList;
        }
    }
}
