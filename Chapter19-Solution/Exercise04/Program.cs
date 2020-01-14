using System;

namespace Exercise04
{
    /// <summary>
    /// Implement a class BiDictionary<K1,K2,T>, which allows adding triplets {key1, key2, value} and quickly search
    /// by either of the keys key1, key2 as well as searching by combination of the both keys.
    /// Note: Adding many elements with the same keys is allowed.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new BiDictionary<string, int, double>();
            dictionary.Add("Sakura", 16, 2.1);
            dictionary.Add("Katsu", 17, 1.6);
            dictionary.Add("Ito", 18, 2.1);
            dictionary.Add("Sakura", 15, 1.8);
            dictionary.Add("Hotaka", 18, 1.9);
            dictionary.Add("Madoka", 17, 4.0);
            dictionary.Add("Sakura", 15, 3.1);
            dictionary.Add("Ito", 20, 2.7);
            dictionary.Add("Sakura", 15, 1.1);
            dictionary.Add("Katsu", 15, 1.3);
            dictionary.Add("Madoka", 17, 1.1);
            dictionary.Add("Madoka", 15, 2.1);
            //Search by first key
            dictionary.SearchByFirstKey("Sakura");
            //Search by second key
            dictionary.SearchBySecondKey(18);
            //Search by both keys
            dictionary.Search("Sakura", 15);
        }
    }
}
