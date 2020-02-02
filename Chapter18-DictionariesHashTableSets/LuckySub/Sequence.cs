using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise13
{
    public class Sequence<T> : IComparable<Sequence<T>> 
    {
        public List<T> Container { get; private set; }
        public int Count { get { return this.Container.Count; } }
        public Sequence(List<T> sequence)
        {
            this.Container = new List<T>(sequence);
        }
        public Sequence(params T[] values)
        {
            this.Container = new List<T>();
            foreach(T t in values)
            {
                this.Container.Add(t);
            }
        }
        public void Add(T value)
        {
            this.Container.Add(value);
        }
        public  void PrintSequence()
        {
            foreach(T item in this.Container)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");
        }
        int IComparable<Sequence<T>>.CompareTo(Sequence<T> other)
        {
            //Sequence<T> sequence = (Sequence<T>)other;
            if(this.Count>other.Count)
            {
                return -1;
            }
            if(Enumerable.SequenceEqual(this.Container, other.Container))
            {
                return 0;
            }
            return 1;
        }
    }
}
