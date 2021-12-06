using System.Collections;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTestinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderedDictionary ordered = new OrderedDictionary();

            ordered.Add(5, "aaaaa");
            ordered.Add(4, "aaaa");
            ordered.Add(3, "aaa");
            ordered.Add(2, "aa");
            ordered.Add(1, "a");
            foreach (DictionaryEntry entry in ordered)
            {
                Console.WriteLine($"{entry.Key}-{entry.Value}");
            }
            if (ordered.Contains(3))
            {
                ordered.Remove(3);
            }
            ordered.Insert(3, 0, "--");
            ordered.Clear();


            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 1);
            hashtable.Add(2, 11);
            hashtable.Add(3, 111);
            hashtable.Add(4, 1111);
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine($"{de.Key}-{de.Value}");
            }

            Queue queue = new Queue();//First in first out

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            var element1 = queue.Dequeue();

            Stack stack = new Stack();//Last in first out
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            var element2 = stack.Pop();//Removes and returns the last element
            var element3 = stack.Peek();//Returns the last element

            HashSet<int> evenNumbers = new HashSet<int> { 2, 4, 6, 8, 10 };//No defined order, elements are unique
            HashSet<int> primeNumbers = new HashSet<int> { 2, 3, 5, 7, 11 };
            HashSet<int> oddNumbers = new HashSet<int> { 1, 3, 5, 7, 9, 11 };
            evenNumbers.Union(primeNumbers);
            oddNumbers.Union(primeNumbers);
            evenNumbers.Intersect(oddNumbers);

            SortedSet<int> sorted = new SortedSet<int>();
            sorted.Add(140);
            sorted.Add(1);
            sorted.Add(2);            
            sorted.Add(56);
            sorted.Add(3);
            
            sorted.Add(1);
            foreach(var i in sorted)
            {
                Console.WriteLine(i);
            }
            int min = sorted.Min;
            int max = sorted.Max;

            sorted.Reverse();
            sorted.Remove(1);
            sorted.Add(140);
            sorted.Distinct();

        }
    }
}
