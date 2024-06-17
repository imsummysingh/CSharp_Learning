using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dictionary example
namespace H_134_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating Dictionary
            Dictionary<int, string> employee = new Dictionary<int, string>()
            {
                { 101,"Ranjeet"},
                {102,"Vicky" },
                {103, "Mani" }
            };

            //foreach for dictionary
            foreach(KeyValuePair<int,string> item in employee)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            Console.WriteLine();

            //keys
            Dictionary<int, string>.KeyCollection keys = employee.Keys;
            foreach(int i in keys)      //here using int, because, the key are of int type, and we just want collection of keys
            {
                Console.WriteLine(i);       //101,102,103
            }

            Console.WriteLine();

            //values
            Dictionary<int, string>.ValueCollection value = employee.Values;
            foreach(string n in value)  //string because need values which is of string type.
            {
                Console.WriteLine(n);
            }

            //Add key
            //Duplicate Key Exception
            //employee.Add(102, "Vishal");    //An item with the same key has already been added.'
            employee.Add(104, "Vishal");

            //remove ->just need key
            employee.Remove(103);

            Console.WriteLine();

            Console.WriteLine("Dictionary after removing an item");
            foreach (KeyValuePair<int, string> item in employee)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            Console.WriteLine();

            //containsKey method
            Console.WriteLine("Conatinas ID:102?->"+employee.ContainsKey(102));

            //ContainsValue method
            Console.WriteLine("Conatinas Name:Vishal?->" + employee.ContainsValue("Vishal"));

            //Clear method
            employee.Clear();         
            

            Console.ReadLine();
        }
    }
}
