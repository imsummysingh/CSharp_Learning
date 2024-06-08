using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Null Propagataion Operator Example.
namespace _76_NullPropagationOperator
{
    class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //p1 is null
            Person p1=null;

            Console.WriteLine(p1?.Age);     //null

            Person p2 = new Person() { Age = 27 };
            Console.WriteLine(p2?.Age);     //27


            Console.ReadLine();
        }
    }
}
