using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");


            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nPopping '{0}'", numbers.Pop());

            Console.WriteLine(numbers.Peek());

            Console.ReadLine();

           // .................

            Queue<int> nums = new Queue<int>();
            nums.Enqueue(23);
            nums.Enqueue(15);
            nums.Enqueue(10);


            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(nums.Peek());
            Console.WriteLine(nums.Dequeue());
            nums.Clear();

            Console.ReadLine();

           // .................

            List<int> num = new List<int>();
            num.Add(12);
            num.Add(10);
            num.Add(8);

            num.Contains(5);

            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

           // ...................

             LinkedList<string> nu = new LinkedList<string>();

            nu.AddFirst("first");
            nu.AddFirst("Add at first");
           
            LinkedListNode<string> mark1 = nu.First;
            nu.RemoveFirst();
            nu.AddLast(mark1);
            Console.WriteLine($"Test 2: Move first node to be last node:{nu}");

            //.....................

            Dictionary<string, string> openwith = new Dictionary<string, string>();

            openwith.Add("1", "first");
            openwith.Add("2", "second");
            openwith.Add("3", "third");
            openwith.Add("4", "fourth");

            Dictionary<string, string>.ValueCollection valucolle = openwith.Values;

            Console.WriteLine();
            foreach (string s in valucolle)
            {
                Console.WriteLine("Value = {0}", s);
            }


            Dictionary<string, string>.KeyCollection keycollec = openwith.Keys;

            Console.WriteLine();
            foreach (string s in keycollec)
            {
                Console.WriteLine("k=={0}", s);

            }
        }
    }
}
