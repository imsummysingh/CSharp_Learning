using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Method example
namespace _19_MethodExample
{
    class Program
    {
        //global variable
        double tax;
        int cost = 1000;
        public double CalculateTax()
        {
            //local variable
            double t;

            //calculate t
            if (cost <= 2000)
            {
                t = cost * 10 / 1000;
            }
            else
            {
                t = cost * 12.5 / 1000;
            }
            return tax = t;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            
            //calling the method
            p.CalculateTax();
            //printing the value of the field which returns the value
            Console.WriteLine("The tax for the given cost is:" +p.tax);
            Console.ReadLine();
        }
    }
}
