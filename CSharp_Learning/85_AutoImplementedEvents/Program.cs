using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Auto Implemented Events Example
namespace _85_AutoImplementedEvents
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

    //Subscriber class
    class Subscriber
    {
        //target method
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of two number is:" + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create obj of the subscriber class
            Subscriber sc = new Subscriber();

            //create obj of the publisher class
            Publisher pc = new Publisher();

            //handle the event or subscribe to event
            pc.myEvent += sc.Add;

            //invoke the event
            pc.RaiseEvent(10, 20);


            Console.ReadLine();
        }
    }
}
