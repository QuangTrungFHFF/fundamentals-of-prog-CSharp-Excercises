using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    class BiDictionary<K1,K2,T> 
    {
        private Dictionary<K1, List<T>> firstKey;
        private Dictionary<K2, List<T>> secondKey;
        public BiDictionary()
        {
            this.firstKey = new Dictionary<K1, List<T>>();
            this.secondKey = new Dictionary<K2, List<T>>();
        }
        public void Add(K1 key1, K2 key2, T value)
        {
            if(!this.firstKey.ContainsKey(key1))
            {
                this.firstKey.Add(key1, new List<T>());
            }
            if (!this.secondKey.ContainsKey(key2))
            {
                this.secondKey.Add(key2, new List<T>());
            }
            this.firstKey[key1].Add(value);
            this.secondKey[key2].Add(value);
        }
        public void SearchByFirstKey(K1 key1)
        {
            List<T> values;
            if(!this.firstKey.TryGetValue(key1,out values))
            {
                Console.WriteLine("Key \"{0}\" not found!", key1.ToString());
                return;
            }
            Console.WriteLine("{0} : ", key1.ToString());
            foreach(var v in values)
            {
                Console.WriteLine(v.ToString() + " ");
            }
        }
        public void SearchBySecondKey(K2 key2)
        {
            List<T> values;
            if (!this.secondKey.TryGetValue(key2, out values))
            {
                Console.WriteLine("Key \"{0}\" not found!", key2.ToString());
                return;
            }
            Console.WriteLine("{0} : ", key2.ToString());
            foreach (var v in values)
            {
                Console.WriteLine(v.ToString() + " ");
            }
        }
        public void Search(K1 key1,K2 key2)
        {
            List<T> first;
            List<T> second;
            if (!this.firstKey.TryGetValue(key1, out first)|| !this.secondKey.TryGetValue(key2,out second))
            {
                Console.WriteLine("Values by keys \"{0},{1}\" not found!",key1.ToString(), key2.ToString());
                return;
            }
            List<T> values = new List<T>();
            foreach(var item in first)
            {
                if(second.Contains(item))
                {
                    values.Add(item);
                }
            }
            Console.WriteLine("{0},{1} : ",key1.ToString(), key2.ToString());
            foreach (var v in values)
            {
                Console.WriteLine(v.ToString() + " ");
            }
        }
    }
}
