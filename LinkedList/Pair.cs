using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Pair<K, V>
    {
        public K key; 
        public V value;

        public Pair(K key, V value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
