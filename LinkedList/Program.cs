﻿namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // AddFirst
            //

           SimpleLinkedList<string> myList1 = new SimpleLinkedList<string>();

            myList1.AddFirst("Cantaloupe");
            myList1.AddFirst("Banan");
            myList1.AddFirst("Apelsin");

            Node<string> myNode = myList1.First;

            while (myNode != null)
            {
                Console.WriteLine(myNode.Value);
                myNode = myNode.Next;
            }
            Console.WriteLine();

            //
            //  Clear
            //

            SimpleLinkedList<int> myList2 = new SimpleLinkedList<int>();
            myList2.AddFirst(8643);
            myList2.AddFirst(3534);
            myList2.AddFirst(6544);
            // skriver ut "count: 3"
            Console.WriteLine("count before: " + myList2.Count());
            myList2.Clear();
            Console.WriteLine("Count after: " + myList2.Count());
            Console.WriteLine(); 

            //
            // ElementAt
            //

            SimpleLinkedList<double> myList3 = new SimpleLinkedList<double>();
            myList3.AddFirst(0.62);
            myList3.AddFirst(8.12);
            myList3.AddFirst(2.24);
            myList3.AddFirst(1.03);

            Console.WriteLine("Element at index 3: "  + myList3.ElementAt(3));
            Console.WriteLine();

            //
            // RemoveFirst
            //

            SimpleLinkedList<string> myList4 = new SimpleLinkedList<string>();
            myList4.AddFirst("Charlie");
            myList4.AddFirst("Bravo");
            myList4.AddFirst("Alpha");

            Console.WriteLine("Element at 0: " + myList4.ElementAt(0));
            myList4.RemoveFirst();
            Console.WriteLine("(RemoveFirst)");
            Console.WriteLine("New element at 0: " + myList4.ElementAt(0));
            Console.WriteLine();
        
            //
            // GenericDuplicateList
            //

            GenericDuplicateList<int> dup = new GenericDuplicateList<int>();    

            List<int> list = new List<int> { 53, 72, 63, 53, 745, 12, 745 };
            Console.WriteLine("Before: " + string.Join(",", list));
            Console.WriteLine("After: " + string.Join(",", dup.Duplicates(list)));
            Console.WriteLine();

            //
            // SimpleDictionary
            //

            SimpleDictioanry<string, int> shoeSize= new SimpleDictioanry<string, int>();

            shoeSize.Add("Sara", 39);
            shoeSize.Add("Lasse", 43);
            shoeSize.Add("Anton", 45);
            shoeSize.Add("Vera", 37);
            shoeSize.Add("Peter", 42);

            Console.WriteLine("Simple Dictionary:");
            Console.WriteLine("Veras shoe size is " + shoeSize.GetValue("Vera"));
            Console.WriteLine();
        }
    }
}
