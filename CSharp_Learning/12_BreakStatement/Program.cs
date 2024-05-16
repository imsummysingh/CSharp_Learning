using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Break- break the execution of the loop
namespace _12_BreakStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i <= 10; i++)
            {
                if (i == 6)
                {
                    break;
                }
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
