using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hash set Example
namespace H_137_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of hash set
            HashSet<string> messages = new HashSet<string>()
            {
                "Good Morning","How are you", "sup?", "What do you do?", "How you"
            };

            //Accessing the hash set
            foreach(string msg in messages)
            {
                Console.WriteLine(msg);
            }
            Console.WriteLine();

            //count property
            Console.WriteLine("No of messages are: " + messages.Count); //4
            Console.WriteLine();

            //add element
            messages.Add("Hey again!");
            Console.WriteLine("Messages of hash set after adding element");
            foreach (string msg in messages)
            {
                Console.WriteLine(msg);
            }
            Console.WriteLine();


            //remove element
            messages.Remove("sup?");
            Console.WriteLine("Messages of hash set after removing element");
            foreach (string msg in messages)
            {
                Console.WriteLine(msg);
            }
            Console.WriteLine();


            //remove predicate -> Remove element if condition matches
            messages.RemoveWhere(m => m.EndsWith("you"));
            Console.WriteLine("Messages of hash set after removing elements which ends with YOU");
            foreach (string msg in messages)
            {
                Console.WriteLine(msg);
            }
            Console.WriteLine();


            //contins method
            bool k = messages.Contains("Good Morning");
            Console.WriteLine("Does messages have Good Morning in it? -> " + k);    //true
            Console.WriteLine();




            //creating two other hash set
            HashSet<int> h1 = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };
            HashSet<int> h2 = new HashSet<int>() { 5, 6, 7, 8, 9 };

            //Unionwith -> unbion of two hash set
            //values will get added in h1 from h2
            h1.UnionWith(h2);
            Console.WriteLine("Union of two hash set value:");
            foreach(int i in h1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //creating two other hash set
            HashSet<int> h3 = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };
            HashSet<int> h4 = new HashSet<int>() { 5, 6, 7, 8, 9 };


            //intersectWith
            h3.IntersectWith(h4);
            Console.WriteLine("Intersect of two hash set value:");
            foreach (int i in h3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
