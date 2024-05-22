using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Implicit conversion Example: converting lower to higher type.
namespace _34_ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte
            sbyte a = 10;

            //Char
            char c = 'A';

            //int
            int b,d;

            //copy value from a to b
            b = a;

            //sbyte to int
            Console.WriteLine("B is:" + b);

            //char to int
            d = c;
            Console.WriteLine("D is:" + d);

            Console.ReadLine();
        }
    }
}
