using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Continue - Skip the current iteration and jump to the next iteration
namespace _13_ContinueStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.Write("Even Numbers are:");
            //skipping odd numbers
            for (int i = 0; i <= 10; i++)
            {               
                if (i % 2 == 1)
                {
                    continue;
                }
                
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
