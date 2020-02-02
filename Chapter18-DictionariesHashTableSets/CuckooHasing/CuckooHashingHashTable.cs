using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise07
{
    /// <summary>
    /// Implement a hash-table, using "cuckoo hashing" with 3 hash-functions.
    /// Solution by Борислав Светославов Статев / Антон Стефанов Богданов
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    internal class CuckooHashingHashTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private const int defaultCapacity = 32;
        private int currentCapacity;
        private Nullable<KeyValuePair<TKey, TValue>>[] hashTable;
        private int count;
        public int Count { get { return this.count; } }

        public TValue this[TKey key]
        {
            get
            {
                int[] hashCodes = GetCuckooHashCode(key);

                foreach (var hashCode in hashCodes)
                {
                    if (hashTable[hashCode] != null && hashTable[hashCode].Value.Key.Equals(key))
                    {
                        return hashTable[hashCode].Value.Value;
                    }
                }
                throw new ArgumentException("Cant find KeyValuePair with this key.");
            }

            set
            {
                int[] hashCodes = GetCuckooHashCode(key);

                foreach (var hashCode in hashCodes)
                {
                    if (hashTable[hashCode] != null && hashTable[hashCode].Value.Key.Equals(key))
                    {
                        hashTable[hashCode] = new KeyValuePair<TKey, TValue>(key, value);
                        return;
                    }
                }
                throw new ArgumentException("Cant find KeyValuePair with this key.");
            }
        }


        public CuckooHashingHashTable(int capacity)
        {
            hashTable = new Nullable<KeyValuePair<TKey, TValue>>[capacity];
            currentCapacity = capacity;
            count = 0;
        }

        public CuckooHashingHashTable() : this(defaultCapacity)
        {
        }
        public void Clear()
        {
            hashTable = new Nullable<KeyValuePair<TKey, TValue>>[defaultCapacity];
            currentCapacity = defaultCapacity;
            count = 0;
        }

        public bool ContainsKey(TKey key)
        {
            int[] hashCodes = GetCuckooHashCode(key);

            foreach (var hashCode in hashCodes)
            {
                if (hashTable[hashCode] != null && hashTable[hashCode].Value.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }


        private int[] GetCuckooHashCode(TKey key)
        {
            var hashCodes = new int[3];
            hashCodes[0] = Math.Abs(key.GetHashCode() % currentCapacity);
            hashCodes[1] = Math.Abs((key.GetHashCode() * 83 + 7) % currentCapacity);
            hashCodes[2] = Math.Abs((key.GetHashCode() + 19) % currentCapacity);
            return hashCodes;
        }

        private void FindNewPlace(KeyValuePair<TKey, TValue>? movingKeyValuePair, int oldPosition, HashSet<int> hashSetVisitedPosiotion)
        {
            int[] hashCodes = GetCuckooHashCode(movingKeyValuePair.Value.Key);
            int numberOfLastPossiblePosition = 0;
            bool needToContinueReplacing = true;
            for (int i = 0; i < hashCodes.Length; i++)
            {
                if (hashCodes[i] == oldPosition)
                {
                    continue;
                }
                if (hashTable[hashCodes[i]] == null)
                {
                    hashTable[hashCodes[i]] = movingKeyValuePair;
                    needToContinueReplacing = false;
                    break;
                }
                numberOfLastPossiblePosition = i;
            }

            if (needToContinueReplacing)
            {
                if (hashSetVisitedPosiotion.Contains(hashCodes[numberOfLastPossiblePosition]))
                {
                    ResizeHashTable();
                    if (hashTable[hashCodes[numberOfLastPossiblePosition]] == null)
                    {
                        hashTable[hashCodes[numberOfLastPossiblePosition]] = movingKeyValuePair;
                    }
                    else
                    {
                        FindNewPlace(movingKeyValuePair, hashCodes[numberOfLastPossiblePosition],
                                     new HashSet<int>() { hashCodes[numberOfLastPossiblePosition] });
                    }
                }
                else
                {
                    HashSet<int> oldHashSetVisitedPosiotion = hashSetVisitedPosiotion;
                    oldHashSetVisitedPosiotion.Add(hashCodes[numberOfLastPossiblePosition]);
                    Nullable<KeyValuePair<TKey, TValue>> newMovingPair = hashTable[hashCodes[numberOfLastPossiblePosition]];
                    hashTable[hashCodes[numberOfLastPossiblePosition]] = movingKeyValuePair;

                    FindNewPlace(newMovingPair, hashCodes[numberOfLastPossiblePosition], oldHashSetVisitedPosiotion);
                }
            }
        }

        private void ResizeHashTable()
        {
            currentCapacity *= 2;
            Nullable<KeyValuePair<TKey, TValue>>[] oldHashTable = hashTable;
            Nullable<KeyValuePair<TKey, TValue>>[] newHashTable = new Nullable<KeyValuePair<TKey, TValue>>[currentCapacity];
            hashTable = newHashTable;
            count = 0;

            foreach (var item in oldHashTable)
            {
                if (item.HasValue)
                {
                    this.Add(item.Value.Key, item.Value.Value);
                }
            }
        }
        public void Add(TKey key, TValue value)
        {
            int[] hashCodes = GetCuckooHashCode(key);
            CheckKeyForDuplicate(hashCodes, key);

            if (hashTable[hashCodes[0]] == null)
            {
                hashTable[hashCodes[0]] = new KeyValuePair<TKey, TValue>(key, value);
            }
            else if (hashTable[hashCodes[1]] == null)
            {
                hashTable[hashCodes[1]] = new KeyValuePair<TKey, TValue>(key, value);
            }
            else
            {
                if (hashTable[hashCodes[2]] == null)
                {
                    hashTable[hashCodes[2]] = new KeyValuePair<TKey, TValue>(key, value);
                }
                else
                {
                    Nullable<KeyValuePair<TKey, TValue>> movingKeyValuePair = hashTable[hashCodes[2]];
                    hashTable[hashCodes[2]] = new KeyValuePair<TKey, TValue>(key, value);
                    FindNewPlace(movingKeyValuePair, hashCodes[2], new HashSet<int>() { hashCodes[2] });
                }
            }
            count++;
        }
        public void Remove(TKey key)
        {
            int[] hashCodes = GetCuckooHashCode(key);

            foreach (var hashCode in hashCodes)
            {
                if (hashTable[hashCode] != null && hashTable[hashCode].Value.Key.Equals(key))
                {
                    hashTable[hashCode] = null;
                    count--;
                    return;
                }
            }
            throw new ArgumentException("Cant find KeyValuePair with this key.");
        }


        private void CheckKeyForDuplicate(int[] hashCodes, TKey key)
        {
            foreach (int item in hashCodes)
            {
                if (hashTable[item].HasValue && hashTable[item].Value.Key.Equals(key))
                {
                    throw new ArgumentException("An element with the same key already exists in the CuckooHashingHashTable<TKey, TValue>.");
                }
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (Nullable<KeyValuePair<TKey, TValue>> pair in hashTable)
            {
                if (pair != null)
                {
                    yield return pair.Value;
                }
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}