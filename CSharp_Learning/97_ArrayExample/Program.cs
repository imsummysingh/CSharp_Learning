using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Array Example
namespace _97_ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array
            int[] a = new int[5] { 10, 20, 30, 40, 50 };   //array of size 5

            //display the value of elements
            //Console.WriteLine(a[0]);    //0
            //Console.WriteLine(a[6]); //should not access the array out of it's size value. Will give System.IndexOutRangeException

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);

            //create an array of string
            string[] b = new string[3] { "Hi", "Hello", "Hola" };
            Console.WriteLine(b[1]);
            Console.WriteLine(b[0]);
            Console.WriteLine(b[2]);


            Console.ReadLine();
        }
    }
}
