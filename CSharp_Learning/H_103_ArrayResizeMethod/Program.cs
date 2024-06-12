using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Array resized method
namespace H_103_ArrayResizeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array
            int[] a = new int[5] { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array before Ressize Method");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);
            }

            //Resize Method
            Array.Resize(ref a, 8);

            Console.WriteLine("Array After Ressize Method");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);
            }


            Console.ReadLine();
        }
    }
}
