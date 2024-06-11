using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Anonymous method example
namespace _86_AnonymousMethod
{
    //delegate Type
    public delegate void MyDelegateType(int a, int b);

    //publisher class
    class Publisher
    {
        //->Auto Implementing Events -> no add and remove accessors;
        public event MyDelegateType myEvent;

        public void RaiseEvent(int a, int b)
        {
            if (this.myEvent != null)
            {
                this.myEvent(a, b);
            }
        }

    }

    ////Subscriber class
    //class Subscriber
    //{
    //    //target method
    //    public void Add(int a, int b)
    //    {
    //        int c = a + b;
    //        Console.WriteLine("Addition of two number is:" + c);
    //    }
    //}


    //subscriber class
    class Program
    {
        static void Main(string[] args)
        {
            //create obj of the publisher class
            Publisher pc = new Publisher();


            //Anonymous Method
            pc.myEvent += delegate (int a, int b)
             {
                 Console.WriteLine("Anonymous Method:");
 
                 Console.WriteLine(a + b);
             };

            //invoke the event
            pc.RaiseEvent(10, 20);


            Console.ReadLine();
        }
    }
}
