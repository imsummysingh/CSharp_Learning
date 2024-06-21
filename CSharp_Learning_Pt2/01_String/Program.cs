using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//String example
namespace _01_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            String y = "Hey";

            Console.WriteLine(x);
            Console.WriteLine(y);


            Console.WriteLine(x.Length);    //5
            Console.WriteLine(y[1]);        //e

            Console.ReadLine();
        }
    }
}
