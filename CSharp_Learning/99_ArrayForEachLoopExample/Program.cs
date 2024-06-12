using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//For each loop example with array
namespace _99_ArrayForEachLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array
            int[] arr = new int[8] { 10, 20, 30, 40, 50, 60, 70, 80 };
            
            //for eaxh loop
            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }


            //creeating an array of string type
            string[] sarr = new string[3] { "Hi", "Hello", "Hola" };
            foreach(string s in sarr)
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();
        }
    }
}
