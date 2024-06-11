using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Inline lambda expression example
namespace _88_InlineLambdaExpression
{
    //delegate Type
    public delegate int MyDelegateType(int a, int b);

    //publisher class
    class Publisher
    {
        //->Auto Implementing Events -> no add and remove accessors;
        public event MyDelegateType myEvent;

        public int RaiseEvent(int a, int b)
        {
            if (this.myEvent != null)
            {
                int x = this.myEvent(a, b);
                return x;
            }
            else { return 0; }
        }

    }

    //subscriber class
    class Program
    {
        static void Main(string[] args)
        {
            //create obj of the publisher class
            Publisher pc = new Publisher();


            //Inline Lamda Expression Method
            pc.myEvent += (a, b) => a + b;

            //invoke the event
            Console.WriteLine(pc.RaiseEvent(10, 20));
            Console.WriteLine(pc.RaiseEvent(70, 10));
            Console.WriteLine(pc.RaiseEvent(5, 29));
            Console.WriteLine(pc.RaiseEvent(67, 10));

            Console.ReadLine();
        }
    }
}
