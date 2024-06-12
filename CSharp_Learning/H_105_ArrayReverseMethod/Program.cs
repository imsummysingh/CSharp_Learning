using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array Reverse Method Example
namespace H_105_ArrayReverseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array
            int[] a = new int[] {10,20,30,40,50,60,70,80,90 };

            Console.WriteLine("Array before Reverse Method");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);
            }

            //Reverse Method
            Array.Reverse(a);

            Console.WriteLine("Array After Reverse Method");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);
            }


            Console.ReadLine();
        }
    }
}
