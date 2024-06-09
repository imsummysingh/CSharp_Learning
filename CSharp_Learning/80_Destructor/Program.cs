using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Destructor Example
namespace _80_Destructor
{
    class Sample
    {
        //constructor
        public Sample()
        {
            Console.WriteLine("Constructor of sample class");
        }

        //destructor
        ~Sample()
        {
            Console.WriteLine("Destructor is called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();

            //Console.ReadLine();
        }
    }
}
