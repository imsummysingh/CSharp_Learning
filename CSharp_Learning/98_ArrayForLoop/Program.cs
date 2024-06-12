using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array For loop Example
namespace _98_ArrayForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array
            int[] a = new int[7] { 10, 20, 30, 40, 50, 60, 70 };

            //for loop for accesing array
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
