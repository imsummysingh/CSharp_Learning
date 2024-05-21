using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//in parameter modifier example. 
namespace _28_inParameterModifier
{
    class Program
    {
        //method definition with 'in' parameter modifier which is x.
        //we cannot modify x inside the definition, we can only read the value.
        //If we will modify it, it will throw compile time error.
        public void increment(in int x)
        {
            Console.WriteLine("The value of N is passed to X from the argument to the parameter");
            Console.WriteLine("The value of x is:" + x);    //5

            //Trying to do some operation on x, it will throw an copile time error:
            //x++;        //cannot assign to variable 'in int' because it is readonly variable

        }
        static void Main(string[] args)
        {
            int n=5;
            Program p = new Program();
            p.increment(in n);
            Console.WriteLine("The value of n from method calling is:" + n);    //5

            Console.ReadLine();
        }
    }
}
