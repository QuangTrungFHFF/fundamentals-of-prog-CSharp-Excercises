using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise13
{
    class Sequence<T> : IComparable<Sequence<T>>
    {
        private List<T> container;
        public int Count { get { return this.container.Count; } }
        public Sequence(List<T> sequence)
        {
            this.container = new List<T>(sequence);
        }
        int IComparable<Sequence<T>>.CompareTo(Sequence<T> other)
        {
            Sequence<T> sequence = (Sequence<T>)other;
            return this.Count.CompareTo(other.Count);
        }
    }
}
