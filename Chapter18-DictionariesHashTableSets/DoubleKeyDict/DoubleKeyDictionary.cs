using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise05
{
    internal class DoubleKeyDictionary<TKey1, TKey2, TValue> : IEnumerable<Tuple<TKey1, TKey2, TValue>>
    {
        private Dictionary<ValueTuple<TKey1, TKey2>, TValue> dictionary;

        //public ValueTuple<TKey1, TKey2> Key { get; set; }
        public int Count { get { return this.dictionary.Count; } }

        public DoubleKeyDictionary()
        {
            this.dictionary = new Dictionary<(TKey1, TKey2), TValue>();
        }

        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            if (!ContainsKeys(key1, key2))
            {
                this.dictionary.Add(ValueTuple.Create(key1, key2), value);
            }
            else
            {
                Console.Error.WriteLine("An item with the same two keys has already been added.");
            }
        }

        public bool ContainsKeys(TKey1 key1, TKey2 key2)
        {
            var key = ValueTuple.Create(key1, key2);
            if (!dictionary.ContainsKey(key))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool TryGetValue(TKey1 key1, TKey2 key2, out TValue value)
        {
            if (ContainsKeys(key1, key2))
            {
                value = dictionary[(key1, key2)];
                return true;
            }
            else
            {
                value = default(TValue);
                return false;
            }
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public bool Remove(TKey1 key1, TKey2 key2)
        {
            if (ContainsKeys(key1, key2))
            {
                dictionary.Remove((key1, key2));
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<Tuple<TKey1, TKey2, TValue>> GetEnumerator()
        {
            foreach (var item in dictionary)
            {
                yield return Tuple.Create(item.Key.Item1, item.Key.Item2, item.Value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Tuple<TKey1, TKey2, TValue>>)this).GetEnumerator();
        }
    }
}