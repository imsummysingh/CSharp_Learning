using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Nested-if statement
namespace _07_NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a >= 10)
            {
                if (a > 10)
                {
                    Console.WriteLine("a is greater than 10");
                }
                else
                {
                    Console.WriteLine("a is equal to 10");
                }
            }
            else
            {
                Console.WriteLine("a is less than 10");
            }
            Console.ReadLine();
        }
    }
}
