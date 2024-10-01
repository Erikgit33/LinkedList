using System.Runtime.CompilerServices;

namespace LinkedList
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

            GenericDuplicateList<int> dup1 = new GenericDuplicateList<int>();

            Console.WriteLine("GenericDuplicateList: int");

            List<int> list1 = new List<int> { 53, 72, 63, 53, 745, 12, 745 };
            Console.WriteLine("Before: " + string.Join(",", list1));
            Console.WriteLine("After: " + string.Join(",", dup1.Duplicates(list1)));
            Console.WriteLine();


            GenericDuplicateList<string> dup2 = new GenericDuplicateList<string>();

            Console.WriteLine("GenericDuplicateList: string");

            List<string> list2 = new List<string> { "Vattenmelon", "Persika", "Banan", "Kiwi", "Satsuma", "Banan", "Vattenmelon", "Drakfrukt" };
            Console.WriteLine("Before: " + string.Join(",", list2));
            Console.WriteLine("After: " + string.Join(",", dup2.Duplicates(list2)));
            Console.WriteLine();

            //
            // SimpleDictionary
            //

            SimpleDictioanry<string, int> shoeSize= new SimpleDictioanry<string, int>();

            shoeSize.Add("Lasse", 43);
            shoeSize.Add("Peter", 42);
            shoeSize.Add("Vera", 37);
            shoeSize.Add("Lennart", 41);


            string shoeSizekey = "Lennart";


            Console.WriteLine("Simple Dictionary: string, int");
            Console.WriteLine("Pair " + shoeSize.GetPair(shoeSizekey) + ": " + shoeSizekey + ", " + shoeSize.GetValue(shoeSizekey));
            Console.WriteLine();

            SimpleDictioanry<bool, double> numbers = new SimpleDictioanry<bool, double>();

            numbers.Add(true, -64);
            numbers.Add(false, 404);


            bool numberskey = false;

            
            Console.WriteLine("SimpleDictionary: bool, double");
            Console.WriteLine("Pair " + numbers.GetPair(numberskey) + ": " + numberskey.ToString() + ", " + numbers.GetValue(numberskey));
            Console.WriteLine();

            SimpleDictioanry<string, double> prices= new SimpleDictioanry<string, double>();

            prices.Add("Piano", 30000);
            prices.Add("Banana", 0.4125);
            prices.Add("Dog", 5000);
            prices.Add("Jacket", 120);
            prices.Add("Something", 552.6423);


            string priceskey = "Piano";


            Console.WriteLine("SimpleDictionary: string, double");
            Console.WriteLine("Pair: " + prices.GetPair("Dog") + ": " + priceskey + ", " + prices.GetValue(priceskey));
            Console.WriteLine();
        }
    }
}
