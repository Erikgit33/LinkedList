using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class GenericDuplicateList<T>
    {
        public List<T> Duplicates(List<T> list)
        {
            List<T> result = new List<T>();
            for (int index1 = 0; index1 < list.Count; index1++)
            {
                for (int index2 = 0; index2 < list.Count; index2++)
                {
                    T element1 = list[index1];
                    T element2 = list[index2];

                    bool isSame = EqualityComparer<T>.Default.Equals(element1, element2);

                    if (isSame == true && index1 != index2 && result.Contains(element1) == false)
                    {
                        result.Add(element1);
                    }
                }
            }
            return result;
        }
    }
}
