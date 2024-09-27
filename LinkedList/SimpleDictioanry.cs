using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SimpleDictioanry<K,V>
    {
        List<Pair<K, V>> list = new List<Pair<K, V>>();
        public int pairIndex = 0;

        public void Add(K Key, V Value)
        {
            Pair<K, V> pair = new Pair<K, V>(Key, Value); 
            list.Add(pair);
        }
        public bool Contains(K Key)
        {
            pairIndex = 0;
            foreach (Pair<K, V> pair in list)
            {
                bool contains = EqualityComparer<K>.Default.Equals(pair.key, Key);
                if (contains) 
                {
                    return true;
                }
                pairIndex++;
            }
            return false;
        }

        public V GetValue(K Key)
        {
            if (Contains(Key)) 
            {
                return list[pairIndex].value;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public int GetPair(K Key)
        {
            if (Contains(Key))
            {
                return pairIndex + 1;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
    }
}
