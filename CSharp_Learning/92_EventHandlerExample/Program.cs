using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Event Handler Example.
namespace _92_EventHandlerExample
{
    //child class of EventArgs
    public class CustomEventArgs: EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    //publisher class
    class Publisher
    {

        //Event Handler
        public event EventHandler<CustomEventArgs> myEvent;

        public void RaiseEvent(object sender, int a,int b)
        {
            if (this.myEvent != null)
            {
                CustomEventArgs cea = new CustomEventArgs() { a = a, b = b };
                this.myEvent(sender, cea);
            }
        }
    }

    //subscriber class
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.DoWork();

            Console.ReadLine();
        }

        public void DoWork()
        {
            //create obj of the publisher class
            Publisher pc = new Publisher();


            //Inline Lamda Expression Method
            pc.myEvent += (sender, e) =>
            {
                int c = e.a + e.b;
                Console.WriteLine(c);
            };

            //invoke the event
            pc.RaiseEvent(this,10, 20);
            pc.RaiseEvent(this,-70, 10);
            pc.RaiseEvent(this,-5, 29);
            pc.RaiseEvent(this,67, 10);
        }
    }
}
