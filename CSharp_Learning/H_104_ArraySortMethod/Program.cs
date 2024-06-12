using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array Sort Method Example
namespace H_104_ArraySortMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array
            int[] a = new int[] { 23,31,12,535,323,546,11,543,75,455 };

            Console.WriteLine("Array before Sort Method");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);
            }

            //Sort Method
            Array.Sort(a);

            Console.WriteLine("Array After Sort Method");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);
            }


            Console.ReadLine();
        }
    }
}
