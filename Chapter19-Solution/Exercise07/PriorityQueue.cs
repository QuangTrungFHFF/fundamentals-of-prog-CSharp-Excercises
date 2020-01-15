using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise07
{
    /// <summary>
    /// Implement the data structure PriorityQueue<T>, which offers quick execution of the following operations: adding an element, extracting the smallest element.
    /// This solution implement a PriorityQueue<T> with Heap data structure. Author: Alexey Kurakin (https://www.codeproject.com/Articles/126751/Priority-Queue-in-Csharp-with-the-Help-of-Heap-Dat)
    /// </summary>
    public class PriorityQueue<TPriority,TValue>
    {
        private List<KeyValuePair<TPriority, TValue>> baseHeap;
        private IComparer<TPriority> comparer;
        #region constructors

        
        public PriorityQueue(IComparer<TPriority> comparer)
        {
            if(comparer == null)
            {
                throw new ArgumentNullException();
            }
            this.baseHeap = new List<KeyValuePair<TPriority, TValue>>();
            this.comparer = comparer;
        }
        public PriorityQueue():this(Comparer<TPriority>.Default)
        {

        }
        #endregion
        #region Methods        
        public void Enqueue(TPriority priority,TValue value)
        {
            Insert(priority, value);
        }
        public KeyValuePair<TPriority,TValue> Dequeue()
        {
            if(this.baseHeap.Count >0)
            {
                KeyValuePair<TPriority, TValue> result = this.baseHeap[0];
                DeleteRoot();
                return result;
            }
            else
            {
                throw new InvalidOperationException("Queue is empty!");
            }
        }
        public TValue GetSmallestElement()
        {
            return Dequeue().Value;
        }
        public KeyValuePair<TPriority, TValue> Peek()
        {
            if (this.baseHeap.Count > 0)
            {
                KeyValuePair<TPriority, TValue> result = this.baseHeap[0];                
                return result;
            }
            else
            {
                throw new InvalidOperationException("Queue is empty!");
            }
        }
        public TValue PeekSmallestElement()
        {
            return Peek().Value;
        }

        /// <summary>
        /// Delete the node with min value and refactor the binary heap tree
        /// </summary>
        private void DeleteRoot()
        {
            if(this.baseHeap.Count<=1)
            {
                this.baseHeap.Clear();
                return;
            }
            this.baseHeap[0] = this.baseHeap[this.baseHeap.Count - 1];
            this.baseHeap.RemoveAt(this.baseHeap.Count - 1);

            HeapifyToEnd(0);
        }

        /// <summary>
        /// Insert new value to the queue
        /// Add this pair to base heap list
        /// heapify after insert, from end to beginning
        /// </summary>
        /// <param name="priority"></param>
        /// <param name="value"></param>
        private void Insert(TPriority priority,TValue value)
        {
            KeyValuePair<TPriority, TValue> val = new KeyValuePair<TPriority, TValue>(priority, value);
            this.baseHeap.Add(val);
            HeapifyToBeginning(this.baseHeap.Count - 1);
        }
        /// <summary>
        /// Heap[i] has a parent at heap[(i-1)/2] and 2 children at [2i+1] and [2i+2]
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        private int HeapifyToBeginning(int position)
        {
            if(position>=this.baseHeap.Count)
            {
                return -1;
            }

            while(position>0)
            {
                int parrent = (position - 1) / 2;
                if((this.comparer.Compare(this.baseHeap[parrent].Key,this.baseHeap[position].Key))>0)
                {
                    ExchangeElements(parrent, position);
                    position = parrent;
                }
                else
                {
                    break;
                }
            }
            return position;
        }
        private void HeapifyToEnd(int position)
        {
            if (position >= this.baseHeap.Count) return;
            while(true)
            {
                int smallest = position;
                int left = 2 * position + 1;
                int right = 2 * position + 2;
                if((left<this.baseHeap.Count && this.comparer.Compare(this.baseHeap[smallest].Key,this.baseHeap[left].Key)>0))
                {
                    smallest = left;
                }
                if ((right < this.baseHeap.Count && this.comparer.Compare(this.baseHeap[smallest].Key, this.baseHeap[right].Key) > 0))
                {
                    smallest = right;
                }
                if(smallest !=position)
                {
                    ExchangeElements(smallest, position);
                    position = smallest;
                }
                else
                {
                    break;
                }

            }
        }

        private void ExchangeElements(int parrent, int position)
        {
            var holder = this.baseHeap[parrent];
            this.baseHeap[parrent] = this.baseHeap[position];
            this.baseHeap[position] = holder;
        }
        #endregion
    }
}
