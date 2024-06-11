using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Func Delegate example.
namespace _89_FuncDelegate
{
    //publisher class
    class Publisher
    {
        //func delegate
        public event Func<int,int, int> myEvent;

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
