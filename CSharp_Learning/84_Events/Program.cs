using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84_Events
{
    //delegate Type
    public delegate void MyDelegateType(int a, int b);

    //publisher class
    class Publisher
    {
        //private delegate -.TO store the reference of the method
        private MyDelegateType myDelegate;

        //step1. create event ->Created based on the delegate
        public event MyDelegateType myEvent
        {
            add
            {
                myDelegate += value;
            }
            remove
            {
                myDelegate -= value;
            }
        }

        //Step2. Raise event
        public void RaiseEvent(int a, int b)
        {
            //raising the event
            //check if delegate is null or not, if it is null nobody is subscribing to it
            if (this.myDelegate != null)
            {
                this.myDelegate(a, b);
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
