using System;

namespace Exercise11
{
    /// <summary>
    /// Implement the data structure dynamic doubly linked list (DoublyLinkedList<T>) – list, the elements of which have pointers both to the next and the previous elements.
    /// Implement the operations for adding, removing and searching for an element, as well as inserting an element at a given index, retrieving an element by a given index
    /// and a method, which returns an array with the elements of the list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
   class DoubleLinkedList<T> where T : IComparable
    {
        public DoubleLinkedListNode<T> First { get; private set; }
        public DoubleLinkedListNode<T> Last { get; private set; }
        public int Count { get; private set; }
        public DoubleLinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void AddFirst(T value)
        {
            if(First == null)
            {
                First = Last = new DoubleLinkedListNode<T>(value);
            }
            else
            {
                First.Previous = new DoubleLinkedListNode<T>(value);
                First.Previous.Next = First;
                First = First.Previous;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            if(Last == null)
            {
                First = Last = new DoubleLinkedListNode<T>(value);
            }
            else
            {
                Last.Next = new DoubleLinkedListNode<T>(value);
                Last.Next.Previous = Last;
                Last = Last.Next;
            }
            Count++;
        }
        public void RemoveFirst()
        {
            if (First == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {                 
                First = First.Next;
                First.Previous = null;
            }
            Count--;
        }
        public void RemoveLast()
        {
            if (Last == null)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {                
                Last = Last.Previous;
                Last.Next = null;
            }
            Count--;
        }
        public void Remove(T value)
        {
            DoubleLinkedListNode<T> currentNode = First;
            bool isRemoved = false;
            while(currentNode!=null&&isRemoved==false)
            {
                if(currentNode.Value.CompareTo(value) == 0)
                {
                    if(currentNode.Previous ==null)
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
        public DoubleLinkedListNode<T> Find(T value)
        {
            DoubleLinkedListNode<T> currentNode = First;            
            while(currentNode!=null)
            {
                if(currentNode.Value.CompareTo(value) ==0)
                {
                    return currentNode;
                }
                currentNode = currentNode.Next;
            }
            return null;
        }
        public void AddBefore(T value,int index)
        {
            DoubleLinkedListNode<T> currentNode = First;
            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
            int currentIndex = 0;
            if(index == 0)
            {
                this.AddFirst(value);
            }
            else if (index == Count)
            {
                this.AddLast(value);
            }
            else if(index > Count|| index <0)
            {
                Console.Error.WriteLine("Out of range");
            }
            else
            {
                while(currentIndex != index)
                {
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
                currentNode.Previous = newNode;
                currentNode.Previous.Next = newNode;
                newNode.Previous = currentNode.Previous;
                newNode.Next = currentNode;
                Count++;
            }
            
        }
        public void AddAfter(T value, int index)
        {
            DoubleLinkedListNode<T> currentNode = First;
            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
            int currentIndex = 0;
            if (index == (Count-1))
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

    }
}