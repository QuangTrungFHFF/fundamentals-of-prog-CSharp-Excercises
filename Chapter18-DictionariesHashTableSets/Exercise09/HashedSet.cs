using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Exercise08;

namespace Exercise09
{
    /// <summary>
    /// Implement the data structure "Set" in a class HashedSet<T>, using your class HashTable<K, T> to hold the elements.
    /// Implement all standard set operations like Add(T), Find(T), Remove(T), Count, Clear(), union and intersect.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class HashedSet<T> : IEnumerable<T>
    {
        public HashTable<T, T> hashSet;        
        public int Count { get { return this.hashSet.Count; } }
        public HashedSet(int capacity)
        {
            this.hashSet = new HashTable<T, T>(capacity);
        }
        public HashedSet()
        {
            this.hashSet = new HashTable<T, T>();
        }
        public bool Add(T value)
        {
            if(Contains(value))
            { 
                return false;
            }
            else
            {
                this.hashSet.Add(value,value);
                return true;
            }
        }
        public bool Find(T value)
        {
            return Contains(value);
        }
        public bool Remove(T value)
        {
            if(Contains(value))
            {
                this.hashSet.Remove(value);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Clear()
        {
            this.hashSet = new HashTable<T, T>();
        }
        public void UnionWith(HashedSet<T> targetSet)
        {
            if(targetSet!= null)
            {
                foreach(var item in targetSet)
                {
                    this.Add(item);
                }
            }
        }
        public void IntersectWith(HashedSet<T> targetSet)
        {
            var result = new HashTable<T,T>();
            if(targetSet!=null)
            {
                foreach(var item in targetSet)
                {
                    result.Add(item,item);
                }
            }
            this.hashSet = result;
        }
        public bool Contains(T value)
        {
            if(this.hashSet.ContainsKey(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this.hashSet.Keys.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        
    }
}
