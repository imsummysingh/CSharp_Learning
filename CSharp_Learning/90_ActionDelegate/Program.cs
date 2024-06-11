using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Action delegate Example
namespace _90_ActionDelegate
{
    //publisher class
    class Publisher
    {
        //Action delegate
        public event Action<int, int> myEvent;

        public void RaiseEvent(int a, int b)
        {
            if (this.myEvent != null)
            {
                this.myEvent(a, b);
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
            pc.myEvent += (a, b) =>
            {
                int c = a + b;
                Console.WriteLine(c);
            };

            //invoke the event
            pc.RaiseEvent(10, 20);
            pc.RaiseEvent(70, 10);
            pc.RaiseEvent(5, 29);
            pc.RaiseEvent(67, 10);

            Console.ReadLine();
        }
    }
}
