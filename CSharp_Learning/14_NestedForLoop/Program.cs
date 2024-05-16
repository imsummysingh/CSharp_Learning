using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Nested for loop
namespace _14_NestedForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                for(int j=0; j <= 5; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
                //Console.WriteLine(i + " ");
            }
            Console.ReadLine();
        }
    }
}
