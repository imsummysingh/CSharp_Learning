using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Dispose Example
namespace _81_Dispose
{
    class Sample : System.IDisposable
    {
        //constructor
        public Sample()
        {
            Console.WriteLine("Constructor is called");
        }
        //method
        public void DisplayData()
        {
            Console.WriteLine("Some method is doing operation");
        }

        //Dispose Method
        public void Dispose()
        {
            Console.WriteLine("Dipose method will work here");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create object using "using structure"
            using (Sample s = new Sample())
            {
                s.DisplayData();
            }
            Console.ReadLine();
        }
    }
}
