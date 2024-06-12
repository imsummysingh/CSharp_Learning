using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array Index Of Example
namespace _100_ArrayIndexOfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array
            double[] a = new double[6] { 10, 20, 30, 40, 50,30 };

            //search 30 in array
            int n = Array.IndexOf(a, 30);
            Console.WriteLine("30 Found at Index:"+n);

            //search 30 in the array for second occurance
            int n1 = Array.IndexOf(a, 30, 3);
            Console.WriteLine("Second occurance of 30 from index 3 is:" + n1);

            Console.ReadLine();
        }
    }
}
