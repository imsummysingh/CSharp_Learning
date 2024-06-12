using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array Clear method Example
namespace H_102_ArrayClearMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            int[] a = new int[] { 10, 20, 30, 40, 50, 60 };

            Console.WriteLine("Array before Clear Method");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);
            }

            //clear elemets of array
            //Array.Clear(a, 0, a.Length);
            Array.Clear(a, 2, 2);   //array, startIndex, length(no. of item need to be cleared)

            Console.WriteLine("Array After Clear Method");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);
            }

            Console.ReadLine();
        }
    }
}
