using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//while loop example
namespace _09_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Increment the loop
            //initialization
            int i = 1;

            //while loop starts here
            while (i <= 10)
            {
                //while block here, do the work here
                Console.Write(i+" ");

                //increment or decrement the loop
                i++;
            }

            //decrement the loop
            Console.WriteLine();
            int j = 10;
            while (j > 0)
            {
                Console.Write(j + " ");
                j--;
            }
            Console.ReadLine();
        }
    }
}
