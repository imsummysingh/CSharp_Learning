using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Method overloading
namespace _23_MethodOverloading
{
    class Program
    {
        //Method with no arg
        public void Methods()
        {
            Console.WriteLine("Method without paramater");
        }

        //Method with 1 arg
        public void Methods(int n1)
        {
            Console.WriteLine("Method with 1 Parameter");
        }

        //Method with 2 arg
        public void Methods(string fname,string lname)
        {
            Console.WriteLine("Method with 2 Arguments");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Methods();
            p.Methods(28);
            p.Methods("Summy", "Singh");

            Console.ReadLine();
        }
    }
}
