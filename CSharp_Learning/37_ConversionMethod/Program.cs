using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Conversion method example
namespace _37_ConversionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value
            int a = 1000;

            //string
            string b;

            //int->string
            b = Convert.ToString(a);

            Console.WriteLine("The value of B is:" + b);

            Console.ReadLine();
        }
    }
}
