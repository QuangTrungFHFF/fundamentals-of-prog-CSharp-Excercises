using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise06
{
    class MultyValueDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, List<TValue>>>
    {
        private Dictionary<TKey, List<TValue>> dictionary;
        public int Count { get { return this.dictionary.Count; } }
        public List<TValue> this[TKey key]
        {
            get
            {
                return dictionary[key];
            }
            set
            {
                dictionary[key] = value;
            }
        }
        public ICollection<TValue> Values
        {
            get
            {
                List<TValue> values = new List<TValue>();
                foreach(var item in dictionary)
                {
                    values.AddRange(item.Value);
                }
                return values;
            }
        }
        public ICollection<TKey> Keys
        {
            get
            {
                List<TKey> keys = new List<TKey>();
                foreach (var item in dictionary)
                {
                    keys.Add(item.Key);
                }
                return keys;
            }
        }
        public MultyValueDictionary()
        {
            this.dictionary = new Dictionary<TKey, List<TValue>>();
        }
        public MultyValueDictionary(TKey key, params TValue[] values)
        {
            this.dictionary = new Dictionary<TKey, List<TValue>>();
            this.dictionary.Add(key, new List<TValue>(values));
        }

        public void Add(TKey key,params TValue[] newValues)
        {
            if(this.dictionary.ContainsKey(key))
            {
                this.dictionary[key].Union(newValues.ToList());
            }
            else
            {
                this.dictionary.Add(key, new List<TValue>(newValues));
            }
        }

        public bool Remove(TKey key)
        {
            if(dictionary.ContainsKey(key))
            {
                dictionary.Remove(key);
                return true;
            }
            return false;
        }
        public void Clear()
        {
            this.dictionary = new Dictionary<TKey, List<TValue>>();
        }
        public bool TryGetValues(TKey key,out List<TValue> values)
        {
            if(this.dictionary.ContainsKey(key))
            {
                values = dictionary[key].ToList();
                return true;
            }
            else
            {
                values = new List<TValue>();
                return false;
            }

        }

        public IEnumerator<KeyValuePair<TKey, List<TValue>>> GetEnumerator()
        {
            foreach(var item in dictionary)
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
