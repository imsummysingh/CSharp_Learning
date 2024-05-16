using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//If-else statement
namespace _05_IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks = 25;

            if (marks >= 35)
            {
                Console.WriteLine("Congratulation you have passed!");
            }
            else
            {
                Console.WriteLine("Sorry, you have failed!");
            }
            Console.ReadLine();
        }
    }
}
