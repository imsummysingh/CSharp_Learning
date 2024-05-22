using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Explicit Casting Example - higher type to lower type.
namespace _35_ExplicitCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value
            int a = 10;

            //sbyte
            sbyte b;

            //convert int to sbyte
            b = (sbyte)a;

            Console.WriteLine("The value of Integer A is:" + a);
            Console.WriteLine("The value of sbyte B after conversion is:" + b);


            Console.ReadLine();
        }
    }
}
