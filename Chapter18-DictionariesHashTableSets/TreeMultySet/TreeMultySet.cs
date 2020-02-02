using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise11
{
    class TreeMultySet<T>
    {
        private SortedDictionary<T, int> treeSet;
        public int Count { get; private set; }
        public TreeMultySet()
        {
            this.treeSet = new SortedDictionary<T, int>();
            this.Count = 0;
        }
        public void Add(T value)
        {
            if(treeSet.ContainsKey(value))
            {
                treeSet[value] += 1;
                this.Count++;
            }
            else
            {
                treeSet.Add(value, 1);
                this.Count++;
            }
        }
        public int FindOccurrences(T value)
        {
            if(this.treeSet.ContainsKey(value))
            {
                return this.treeSet[value];
            }
            else
            {
                return 0;
            }
        }
        public T FindMax()
        {
            return this.treeSet.Keys.Last();
        }
        public T FindMin()
        {
            return this.treeSet.Keys.First();
        }
        public void DeleteMin()
        {
            T min = FindMin();
            while(this.treeSet.ContainsKey(min))
            {
                this.Delete(min);
                this.Count--;
            }
            Console.WriteLine("Min value removed!");
        }
        public void DeleteMax()
        {
            T max = FindMax();
            while (this.treeSet.ContainsKey(max))
            {
                this.Delete(max);
                this.Count--;
            }
            Console.WriteLine("Max value removed!");
        }
        public void PrintTree()
        {
            foreach(var item in this.treeSet)
            {
                for(int i =0;i<item.Value;i++)
                {
                    Console.WriteLine(item.Key.ToString());
                }
            }
        }
        public void Delete(T value)
        {
            if(this.treeSet.ContainsKey(value))
            {
                int count = treeSet[value];
                if(count >1)
                {
                    treeSet[value] = count - 1;
                    this.Count--;
                }
                else
                {
                    treeSet.Remove(value);
                    this.Count--;
                }
                Console.WriteLine("Success! Removed {0}", value.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find element {0}",value.ToString());
            }
        }
    }
}
