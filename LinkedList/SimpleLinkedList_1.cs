using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SimpleLinkedList<T>
    {
        public Node<T> First;

        public void AddFirst(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = item;

            if (First != null)
            {
                newNode.Next = First;
            }
            First = newNode;
        }

        public int Count()
        {
            Node<T> myNode = First;
            int count = 0;

            while (myNode != null)
            {
                myNode = myNode.Next;
                count++;
            }
            return count;
        }

        public void Clear()
        {
            First = null;
            
/*            Node<T> myNode = First;

            while (count != 0)
            {
                myNode = myNode.Next;
                if (myNode.Next == null)
                {
                    myNode = First;   
                    count--;
                }
            }
*/      }

        public T ElementAt(int index)
        {
            Node<T> myNode = First;

            int elementsToIndex = 0;
            while (elementsToIndex < index)
            {
                if (myNode == null)
                {
                    throw new IndexOutOfRangeException();
                }
                myNode = myNode.Next;
                elementsToIndex++;
            }
            return myNode.Value;
            
        }

        public void RemoveFirst()
        {
/*            Node<T> myNode = First;
            First = myNode.Next;
*/        
            First = First.Next;
        }
    }
}
