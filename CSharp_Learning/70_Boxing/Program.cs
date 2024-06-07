using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Boxing example
namespace _70_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitive value
            int x = 10;

            //Boxing(Value-type -> Reference-Type)
            //System.Object obj or object obj
            object obj = x;

            Console.WriteLine("X:" + x);        //10
            Console.WriteLine("Obj X:" + obj);  //10


            Console.ReadLine();
        }
    }
}
