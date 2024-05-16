using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//If-else-if statement
namespace _06_IfElseIf_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks = 65;

            if (marks >= 80)
            {
                Console.WriteLine("Grade A");
            }else if (marks >= 60 && marks < 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 35 && marks < 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Sorry, You have failed!");
            }
            Console.ReadLine();
        }
    }
}
