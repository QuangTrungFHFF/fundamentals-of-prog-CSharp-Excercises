using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise08
{
    /// <summary>
    /// Implement the data structure hash-table in a class HashTable<K,T>.
    /// Keep the data in an array of key-value pairs (KeyValuePair<K,T>[]) with initial capacity of 16.
    /// Resole the collisions with quadratic probing. When the hash table load runs over 75%, perform resizing to 2 times larger capacity.
    /// Implement the following methods and properties: Add(key, value), Find(key)  value, Remove(key), Count, Clear(), this[] and Keys.
    /// Try to make the hash-table to support iterating over its elements with foreach.
    /// Solution by Борислав Светославов Статев / Антон Стефанов Богданов
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int defaultCapacity = 16;
        private int currentCapacity;
        private float defaultLoadFactor = 0.75f;
        private int currentLoad;
        private int count;
        private LinkedList<KeyValuePair<K, T>>[] hashTable;

        public HashTable() : this(defaultCapacity)
        {
        }

        public HashTable(int capacity)
        {
            this.hashTable = new LinkedList<KeyValuePair<K, T>>[capacity];
            currentCapacity = capacity;
            count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public T this[K key]
        {
            get
            {
                return Find(key);
            }
            set
            {
                if (this.ContainsKey(key))
                {
                    this.Remove(key);
                    this.Add(key, value);
                }
                else
                {
                    this.Add(key, value);
                }
            }
        }

        public ICollection<K> Keys
        {
            get
            {
                List<K> returnKeys = new List<K>();
                foreach (LinkedList<KeyValuePair<K, T>> item in hashTable)
                {
                    if (item != null)
                    {
                        foreach (KeyValuePair<K, T> element in item)
                        {
                            returnKeys.Add(element.Key);
                        }
                    }
                }
                return returnKeys;
            }
        }

        public ICollection<T> Values
        {
            get
            {
                List<T> returnValues = new List<T>();
                foreach (LinkedList<KeyValuePair<K, T>> item in hashTable)
                {
                    if (item != null)
                    {
                        foreach (KeyValuePair<K, T> element in item)
                        {
                            returnValues.Add(element.Value);
                        }
                    }
                }
                return returnValues;
            }
        }

        public void Add(K key, T value)
        {
            if (currentLoad > hashTable.Length * 0.75)
            {
                Resize();
            }
            int hashCode = GetHash(key);
            if (hashTable[hashCode] == null)
            {
                LinkedList<KeyValuePair<K, T>> newList = new LinkedList<KeyValuePair<K, T>>();
                newList.AddFirst(new KeyValuePair<K, T>(key, value));
                hashTable[hashCode] = newList;
                count++;
                currentLoad++;
            }
            else
            {
                foreach (var item in hashTable[hashCode])
                {
                    if (item.Key.Equals(key))
                    {
                        throw new Exception("Key is already in a HashTable:");
                    }
                }
                hashTable[hashCode].AddLast(new KeyValuePair<K, T>(key, value));
                count++;
            }
        }

        public T Find(K key)
        {
            if (hashTable[GetHash(key)] != null)
            {
                foreach (KeyValuePair<K, T> item in hashTable[GetHash(key)])
                {
                    if (key.Equals(item.Key))
                    {
                        return item.Value;
                    }
                }
            }
            throw new Exception("Key not exist.");
        }

        public bool ContainsKey(K key)
        {
            if (hashTable[GetHash(key)] != null)
            {
                foreach (KeyValuePair<K, T> item in hashTable[GetHash(key)])
                {
                    if (key.Equals(item.Key))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Remove(K key)
        {
            int hashCode = GetHash(key);
            if (hashTable[hashCode] == null)
            {
                return;
            }
            KeyValuePair<K, T> toRemovePair = new KeyValuePair<K, T>();
            foreach (KeyValuePair<K, T> item in hashTable[hashCode])
            {
                if (item.Key.Equals(key))
                {
                    toRemovePair = item;
                }
            }
            hashTable[hashCode].Remove(toRemovePair);
            count--;
        }

        public void Clear()
        {
            this.hashTable = new LinkedList<KeyValuePair<K, T>>[defaultCapacity];
            count = 0;
            currentLoad = 0;
        }

        private void Resize()
        {
            currentCapacity *= 2;
            LinkedList<KeyValuePair<K, T>>[] oldHashTable = hashTable;
            LinkedList<KeyValuePair<K, T>>[] newHashTable = new LinkedList<KeyValuePair<K, T>>[currentCapacity];
            hashTable = newHashTable;
            count = 0;
            currentLoad = 0;
            foreach (LinkedList<KeyValuePair<K, T>> item in oldHashTable)
            {
                if (item != null)
                {
                    foreach (KeyValuePair<K, T> element in item)
                    {
                        Add(element.Key, element.Value);
                    }
                }
            }
        }

        private int GetHash(K key)
        {
            int hash = key.GetHashCode();
            if (hash < 0)
            {
                hash = -hash;
            }
            return hash % hashTable.Length;
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (LinkedList<KeyValuePair<K, T>> chain in hashTable)
            {
                if (chain != null)
                {
                    foreach (KeyValuePair<K, T> pair in chain)
                    {
                        yield return pair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}