using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise12
{
    /// <summary>
    /// Create a DynamicStack<T> class to implement dynamically a stack (like a linked list, where each element knows its previous element and the stack knows its last element).
    /// Add methods for all commonly used operations like Push(), Pop(), Peek(), Clear() and Count.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class DynamicStack<T> where T : IComparable
    {
        public Node<T> First { get; private set; }
        public int Count { get; private set; }
        public DynamicStack()
        {
            First = null;
            Count = 0;
        }
        public DynamicStack(T value)
        {
            First = new Node<T>(value);
            Count = 1;
        }
        /// <summary>
        /// Inserts an object at the top of the DynamicStack<T>.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            if(First == null)
            {
                First = new Node<T>(value);
            }
            else
            {
                Node<T> temp = First;                
                First = new Node<T>(value);
                First.Next = temp;
            }
            Count++;
        }
        /// <summary>
        /// Removes and returns the object at the top of the DynamicStack<T>.
        /// </summary>
        /// <returns></returns>
        public Node<T> Pop()
        {
            Node<T> result;
            if(Count == 0)
            {
                return null;
            }
            else if (Count ==1)
            {
                result = First;
                First = null;
            }
            else
            {
                result = First;
                First = First.Next;
            }
            Count--;
            return First;
        }
        /// <summary>
        /// Returns the object at the top of the DynamicStack<T> without removing it.
        /// </summary>
        /// <returns></returns>
        public Node<T> Peek()
        {            
            if (Count == 0)
            {
                return null;
            } 
            return First;
        }
        /// <summary>
        /// Removes all objects from the DynamicStack<T>.
        /// </summary>
        public void Clear()
        {
            First = null;
            Count = 0;
        }
        public T[] ToArray()
        {
            Node<T> current = First;
            T[] result = new T[Count];
            for(int i=0;i<Count;i++)
            {
                result[i] = current.Value;
                current = current.Next;
            }
            return result;
        }

    }
}
