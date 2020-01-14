using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    class ValuesHolder<T> : IEnumerable<T>
    {
        public List<T> Values { get; private set; }
        public int Count { get { return this.Values.Count; } }
        public ValuesHolder()
        {
            this.Values = new List<T>();
        }
        public ValuesHolder(params T[] values)
        {
            this.Values = new List<T>();
            foreach (T value in values)
            {
                this.Values.Add(value);
            }
        }
        public void Add(params T[] values)
        {
            foreach(T value in values)
            {
                this.Values.Add(value);
            }
        }
        public void Remove(T value)
        {
            if(value != null)
            {
                this.Values.Remove(value);
            }
        }
        public void Clear()
        {
            this.Values = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T item in this.Values)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
