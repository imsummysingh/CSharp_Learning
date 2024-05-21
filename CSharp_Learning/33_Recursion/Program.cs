using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Recursion Example - Factorial
namespace _33_Recursion
{
    class Sample
    {
        public double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Read number from keyboad
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            //Creating object of sample
            Sample s = new Sample();
            double fact = s.Factorial(n);
            //Console.WriteLine("Factorial of {0} is {1}", n, fact);
            Console.WriteLine("Factorial of " + n + " is " + fact);

            Console.ReadLine();
        }
    }
}
