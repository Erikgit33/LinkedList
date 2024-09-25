using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SimpleDictioanry<K,V>
    {
        Dictionary<K, V> dict = new Dictionary<K, V>();
        public void Add(K Key, V value)
        {
            dict.Add(Key, value);
        }
        public bool Contains(K Key)
        {
            if (dict.ContainsKey(Key))
            {
                return true;
            }
            return false;
        }

        public V GetValue(K Key)
        {
            if (Contains(Key)) 
            {
                return dict[Key];
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
    }
}
