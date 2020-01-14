using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise13
{
    internal class TreeMultySet<T> : IEnumerable<KeyValuePair<T, int>>
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
            if (treeSet.Keys.Contains(value))
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
            if (this.treeSet.ContainsKey(value))
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
            while (this.treeSet.ContainsKey(min))
            {
                this.Delete(min);
                this.Count--;
            }
            //Console.WriteLine("Min value removed!");
        }

        public void DeleteAllMax()
        {
            T max = FindMax();
            while (this.treeSet.ContainsKey(max))
            {
                this.Delete(max);
                this.Count--;
            }
            //Console.WriteLine("All Max value removed!");
        }

        public void DeleteSingleMax()
        {
            T max = FindMax();
            this.Delete(max);
            this.Count--;
        }

        public void PrintTree()
        {
            foreach (var item in this.treeSet)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.WriteLine(item.Key.ToString());
                }
            }
        }

        public void Delete(T value)
        {
            if (this.treeSet.ContainsKey(value))
            {
                int count = treeSet[value];
                if (count > 1)
                {
                    treeSet[value] = count - 1;
                    this.Count--;
                }
                else
                {
                    treeSet.Remove(value);
                    this.Count--;
                }
                //Console.WriteLine("Success! Removed {0}", value.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find element {0}", value.ToString());
            }
        }

        public IEnumerator<KeyValuePair<T, int>> GetEnumerator()
        {
            foreach (KeyValuePair<T, int> pair in this.treeSet)
            {
                yield return pair;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}