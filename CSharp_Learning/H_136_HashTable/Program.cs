using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hash Table Example
namespace H_136_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hash Table
            Hashtable employeees = new Hashtable()
            {
                { 101, "Ranjeet"},
                { 102, "Vicky" },
                { "Hello", 01 },
                { "Hey", 03 },
                {103,"Vishal" },
                { 104,"Mani"}
            };

            //reading hash table elements
            Console.WriteLine("Reading hash table");
            foreach(DictionaryEntry item in employeees)
            {
                Console.WriteLine(item.Key +", "+item.Value);
            }
            Console.WriteLine();

            //add element
            employeees.Add("Hola", 04);
            Console.WriteLine("Reading hash table after adding element");
            foreach (DictionaryEntry item in employeees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }
            Console.WriteLine();

            //remove element
            employeees.Remove(104);
            Console.WriteLine("Reading hash table after removing element");
            foreach (DictionaryEntry item in employeees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }
            Console.WriteLine();

            //foreach
            //foreach (var item in employeees)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //get value based on keys
            if (employeees[103] is string)
            {
                string value = Convert.ToString(employeees[103]);
                Console.WriteLine("Employee Name at 103: "+value);
            }
            if(employeees[103] is double)
            {
                double value = Convert.ToDouble(employeees[103]);
                Console.WriteLine("Employee Name at 103: "+value);
            }
            Console.WriteLine();


            //search for specific key
            bool k = employeees.ContainsKey("hello");
            Console.WriteLine("Hash Table contains key name hello? : " + k);
            Console.WriteLine();


            //search for specific value
            bool kk = employeees.ContainsValue(03);
            Console.WriteLine("Hash table contains value of 03? :" + kk);
            Console.WriteLine();

            //Keys
            Console.WriteLine("Keys:");
            foreach (var item in employeees.Keys)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            //Values
            Console.WriteLine("BValues:");
            foreach (var item in employeees.Values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
