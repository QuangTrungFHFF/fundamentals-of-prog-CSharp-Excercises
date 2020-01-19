using System;

namespace Exercise14
{
    internal class CircularQueueArray<T> where T : IComparable
    {
        private const int defaultCapacity = 5;
        public int HeadIndex { get; set; }
        public int TailIndex { get; set; }
        public int CurrentCapacity { get; private set; }
        public int Count { get; private set; }
        public T[] QueueArray { get; private set; }

        public CircularQueueArray()
        {
            QueueArray = new T[defaultCapacity];
            Count = 0;
            HeadIndex = 0;
            TailIndex = 0;
            CurrentCapacity = defaultCapacity;
        }

        public void Enqueue(T value)
        {
            if (Count == CurrentCapacity)
            {
                this.AutoResize();
            }
            QueueArray[TailIndex] = value;
            if (TailIndex < (QueueArray.Length - 1))
            {
                TailIndex++;
            }
            else if (TailIndex == QueueArray.Length - 1)
            {
                TailIndex = 0;
            }
            Count++;
        }

        public T DeQueue()
        {
            T dequeu = QueueArray[HeadIndex];
            if (Count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                QueueArray[HeadIndex] = default;
                HeadIndex++;
                Count--;
            }

            return dequeu;
        }

        public T Peek()
        {
            T dequeu = QueueArray[HeadIndex];
            if (Count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            return dequeu;
        }

        public void Clear()
        {
            QueueArray = new T[defaultCapacity];
            Count = 0;
            HeadIndex = 0;
            TailIndex = 0;
            CurrentCapacity = defaultCapacity;
        }

        public void AutoResize()
        {
            CurrentCapacity = CurrentCapacity * 2;
            T[] newQueueArray = new T[CurrentCapacity];
            int tempPosition = HeadIndex;
            for (int i = 0; i < QueueArray.Length; i++)
            {
                newQueueArray[i] = QueueArray[tempPosition];
                if (tempPosition == (this.Count - 1))
                {
                    tempPosition = -1;
                }
                tempPosition++;
            }
            this.HeadIndex = 0;
            this.TailIndex = Count;
            QueueArray = newQueueArray;
        }
        
    }
}