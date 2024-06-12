using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Array Binary Search Example
namespace H_101_ArrayBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array
            double[] a = new double[6] { 10, 20, 30, 40, 50, 30 };

            //search 30 in array
            int n = Array.BinarySearch(a, 30);
            Console.WriteLine("30 Found at Index:" + n);

            Console.ReadLine();
        }
    }
}
