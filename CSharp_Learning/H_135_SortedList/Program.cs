using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorted List Example
namespace H_135_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //sorted List ->Duplicate keys are not allowed.
            SortedList<int, string> employees = new SortedList<int, string>()
            {
                {101,"Ranjeet" },
                {102,"Vicky" },
                {103, "Vishal" },
                {104, "Mani" }
            };

            //reading sorted list
            Console.WriteLine("Reading sorted List");
            foreach(KeyValuePair<int,string> emp in employees)
            {
                Console.WriteLine(emp.Key + ", " + emp.Value);
            }
            Console.WriteLine();


            //add element
            employees.Add(99, "Avanish");
            Console.WriteLine("Reading After adding element in sorted List");
            foreach (KeyValuePair<int, string> emp in employees)
            {
                Console.WriteLine(emp.Key + ", " + emp.Value);
            }
            Console.WriteLine();

            //remove element
            employees.Remove(103);
            Console.WriteLine("Reading After Removing element in sorted List");
            foreach (KeyValuePair<int, string> emp in employees)
            {
                Console.WriteLine(emp.Key + ", " + emp.Value);
            }
            Console.WriteLine();


            //get value based on key
            string eName = employees[104];
            Console.WriteLine("Emp at 104:" + eName);
            Console.WriteLine();


            //search for specific key
            bool k = employees.ContainsKey(105);
            Console.WriteLine("105 exists? : " + k);    //false
            Console.WriteLine();


            //search for particular value
            bool kk = employees.ContainsValue("Shubham");
            Console.WriteLine("Shubham exists? : " + kk);    //false
            Console.WriteLine();


            //Index for specific key
            int ki = employees.IndexOfKey(99);
            Console.WriteLine("Index of key 99: " + ki);    
            Console.WriteLine();

            //Index for specific value
            int kii = employees.IndexOfValue("Vicky");
            Console.WriteLine("Index of value Vicky: " + kii);
            Console.WriteLine();

            //Keys
            Console.WriteLine("Keys:");
            foreach(int item in employees.Keys)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //Values
            Console.WriteLine("BValues:");
            foreach(string item in employees.Values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //clear item->Removes all element
            employees.Clear();

            Console.ReadLine();
        }
    }
}
