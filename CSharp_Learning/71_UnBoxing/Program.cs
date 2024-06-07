using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Unboxing Example
namespace _71_UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //reference type value
            //System.Object obj or object obj
            object obj = 10;

            //UnBoxing(Reference-Type -> Value-type)
            
            int x = (int)obj;

            Console.WriteLine("X:" + x);        //10
            Console.WriteLine("Obj X:" + obj);  //10


            Console.ReadLine();
        }
    }
}
