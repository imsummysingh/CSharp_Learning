using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Predicate Delegate Example
namespace _91_PredicateDelegate
{
    //publisher class
    class Publisher
    {
        //Predicate delegate
        public event Predicate<int> myEvent;

        public bool RaiseEvent(int a)
        {
            if (this.myEvent != null)
            {
                bool result = this.myEvent(a);
                return result;
            }
            else
            {
                return false;
            }
        }
    }

    //subscriber class
    class Program
    {
        static void Main(string[] args)
        {
            //create obj of the publisher class
            Publisher pc = new Publisher();


            //Lamda Expression Method
            pc.myEvent += (a) =>
            {
                return a >= 0;
            };

            //invoke the event
            Console.WriteLine(pc.RaiseEvent(10));
            Console.WriteLine(pc.RaiseEvent(-70));
            Console.WriteLine(pc.RaiseEvent(-56));
            Console.WriteLine(pc.RaiseEvent(01));

            Console.ReadLine();
        }
    }
}
