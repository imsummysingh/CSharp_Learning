using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//do while loop
namespace _10_DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i + " ");
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
