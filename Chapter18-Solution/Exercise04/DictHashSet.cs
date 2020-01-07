using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise04
{
    class DictHashSet<T> : IEnumerable<T>
    {
        private Dictionary<T, T> valuePairs;
        public int Count { get { return this.valuePairs.Count; } }
        public DictHashSet()
        {
            this.valuePairs = new Dictionary<T, T>();
        }
        public bool Add(T value)
        {
            T item;
            if(this.valuePairs.TryGetValue(value,out item))
            {
                return false;
            }
            else
            {
                this.valuePairs[value] = value;
                return true;
            }
        }
        public bool Contain(T value)
        {
            T item;
            if (this.valuePairs.TryGetValue(value, out item))
            {
                return true;
            }
            else
            {                
                return false;
            }
        }
        public void Clear()
        {
            this.valuePairs.Clear();
            Console.WriteLine("The DictHashset is now empty!");
        }
        /// <summary>
        /// Copies the elements of a HashSet<T> collection to an array.
        /// </summary>
        /// <returns></returns>
        public T[] CopyTo()
        {
            if(this.Count ==0)
            {
                throw new ArgumentNullException("There is no items in the set!");
            }
            return this.valuePairs.Keys.ToArray();
        }
        /// <summary>
        /// true if the element is successfully found and removed; otherwise, false.
        /// This method returns false if item is not found in the set.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Remove(T value)
        {
            if(this.Contain(value))
            {
                this.valuePairs.Remove(value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Modifies the current DictHashSet<T> object to contain all elements that are present in itself, the specified collection, or both.
        /// </summary>
        /// <param name="other">The collection to compare to the current DictHashSet<T> object.</param>
        public void UnionWith(DictHashSet<T> other)
        {
            if(other == null)
            {
                Console.WriteLine("Cannot union with null DictHashSet!");
            }
            else
            {
                foreach (var value in other)
                {
                    this.Add(value);
                }
            }
        }
        /// <summary>
        /// Modifies the current DictHashSet<T> object to contain only elements that are present in that object and in the specified collection.
        /// </summary>
        /// <param name="other"></param>
        public void IntersectWith(DictHashSet<T> other)
        {
            if(other == null)
            {
                Console.WriteLine("Cannot intersect with null DictHashSet!");
            }
            else
            {
                foreach(var item in this)
                {
                    if(!other.Contain(item))
                    {
                        this.Remove(item);
                    }
                }
            }
        }
        /// <summary>
        /// Removes all elements in the specified collection from the current DictHashSet<T> object.
        /// </summary>
        /// <param name="other"></param>
        public void ExceptWith(DictHashSet<T> other)
        {
            if (other == null)
            {
                Console.WriteLine("Cannot intersect with null DictHashSet!");
            }
            else
            {
                foreach (var item in this)
                {
                    if (other.Contain(item))
                    {
                        this.Remove(item);
                    }
                }
            }
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in this.valuePairs)
            {
                yield return item.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
