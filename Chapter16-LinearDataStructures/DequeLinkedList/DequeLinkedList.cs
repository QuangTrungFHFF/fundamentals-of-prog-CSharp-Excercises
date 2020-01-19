using System;

namespace Exercise13
{
    /// <summary>
    /// Implement the data structure "Deque".
    /// This is a specific list-like structure, similar to stack and queue, allowing to add elements at the beginning and at the end of the structure.
    /// Implement the operations for adding and removing elements, as well as clearing the deque.
    /// If an operation is invalid, throw an appropriate exception.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class DequeLinkedList<T> where T : IComparable
    {
        public DequeLinkedListNode<T> First { get; private set; }
        public DequeLinkedListNode<T> Last { get; private set; }
        public int Count { get; private set; }

        public DequeLinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        /// <summary>
        /// Add an element at the beginning of the list
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(T value)
        {
            if (First == null)
            {
                First = Last = new DequeLinkedListNode<T>(value);
            }
            else
            {
                First.Previous = new DequeLinkedListNode<T>(value);
                First.Previous.Next = First;
                First = First.Previous;
            }
            Count++;
        }

        /// <summary>
        /// Add an element to the end of the list
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            if (Last == null)
            {
                First = Last = new DequeLinkedListNode<T>(value);
            }
            else
            {
                Last.Next = new DequeLinkedListNode<T>(value);
                Last.Next.Previous = Last;
                Last = Last.Next;
            }
            Count++;
        }

        /// <summary>
        /// Remove the first element of the list
        /// </summary>
        public void RemoveFirst()
        {
            if(Count == 0)            
            {
                Console.WriteLine("List is empty!");
            }
            else if(Count == 1)
            {
                First = null;
                Last = null;
                Count = 0;
            }
            else
            {
                First = First.Next;
                First.Previous = null;
                Count--;
            }
            
        }

        /// <summary>
        /// Remove an element to the end of the list
        /// </summary>
        public void RemoveLast()
        {
            if (Count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else if (Count == 1)
            {
                First = null;
                Last = null;
                Count = 0;
            }
            else
            {
                Last = Last.Previous;
                Last.Next = null;
                Count--;
            }
        }

        /// <summary>
        /// Remove the first element with the given value
        /// </summary>
        /// <param name="value"></param>
        public void Remove(T value)
        {
            DequeLinkedListNode<T> currentNode = First;
            bool isRemoved = false;
            while (currentNode != null && isRemoved == false)
            {
                if (currentNode.Value.CompareTo(value) == 0)
                {
                    if (currentNode.Previous == null)
                    {
                        this.RemoveFirst();
                    }
                    else if (currentNode.Next == null)
                    {
                        this.RemoveLast();
                    }
                    else
                    {
                        currentNode.Next.Previous = currentNode.Previous;
                        currentNode.Previous.Next = currentNode.Next;
                        currentNode = null;
                        Count--;
                        isRemoved = true;
                    }
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }
        /// <summary>
        /// Find the first element with the given value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DequeLinkedListNode<T> Find(T value)
        {
            DequeLinkedListNode<T> currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(value) == 0)
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }
            return null;
        }

        /// <summary>
        /// Add an element before a given index
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void AddBefore(T value, int index)
        {
            DequeLinkedListNode<T> currentNode = First;
            DequeLinkedListNode<T> newNode = new DequeLinkedListNode<T>(value);
            int currentIndex = 0;
            if (index == 0)
            {
                this.AddFirst(value);
            }
            else if (index == Count)
            {
                this.AddLast(value);
            }
            else if (index > Count || index < 0)
            {
                Console.Error.WriteLine("Out of range");
            }
            else
            {
                while (currentIndex != index)
                {
                    currentNode = currentNode.Next;
                    currentIndex++;
                }                                               
                newNode.Previous = currentNode.Previous;
                currentNode.Previous.Next = newNode;
                currentNode.Previous = newNode;
                newNode.Next = currentNode;
                Count++;
            }
        }

        /// <summary>
        /// Add an element after a given index
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void AddAfter(T value, int index)
        {
            DequeLinkedListNode<T> currentNode = First;
            DequeLinkedListNode<T> newNode = new DequeLinkedListNode<T>(value);
            int currentIndex = 0;
            if (index == (Count - 1))
            {
                this.AddLast(value);
            }
            else if (index >= Count || index < 0)
            {
                Console.Error.WriteLine("Out of range");
            }
            else
            {
                while (currentIndex != index)
                {
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
                newNode.Next = currentNode.Next;
                newNode.Previous = currentNode;
                currentNode.Next.Previous = newNode;
                currentNode.Next = newNode;
                Count++;
            }
        }

        /// <summary>
        /// Retrieving an element by a given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public DequeLinkedListNode<T> GetElementAtIndex(int index)
        {
            DequeLinkedListNode<T> currentNode = First;
            int currentIndex = 0;
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                while (currentIndex != index)
                {
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
                return currentNode;
            }
        }

        /// <summary>
        /// Returns an array with the elements of the list
        /// </summary>
        /// <returns></returns>
        public T[] ToArray()
        {
            DequeLinkedListNode<T> currentNode = First;
            T[] result = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                
                result[i] = currentNode.Value;
                               

                currentNode = currentNode.Next;
            }
            return result;
        }
        public void Clear()
        {
            while(First!=null)
            {
                this.RemoveFirst();
            }
        }
    }
}