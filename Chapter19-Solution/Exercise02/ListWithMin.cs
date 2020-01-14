using System;
using System.Collections.Generic;

namespace Exercise02
{
    class ListWithMin<T> where T : IComparable
    {
        private List<T> list;
        public T Min { get; private set; }
        
        public ListWithMin()
        {
            this.list = new List<T>();
        }
        public ListWithMin(List<T> values)
        {
            values.Sort();
            this.list = new List<T>(values);
            this.Min = list[0];
        }
        public ListWithMin(T value)
        {
            this.list = new List<T>();
            this.list.Add(value);
            this.Min = value;
        }
        public void Add(T value)
        {
            this.list.Add(value);
            if(this.Min == null)
            {
                this.Min = value;
                return;
            }
            if (this.Min.CompareTo(value) ==1)
            {
                this.Min = value;
            }
        }
    }
}