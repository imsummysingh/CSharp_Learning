using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//for-loop example
namespace _11_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {   //for(initialization; condition; incr/decr)
            for(int i=0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
