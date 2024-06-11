using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//multi cast delegate example
namespace _83_MultiCastDelegate
{
    class Sample
    {
        //target method 1
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of two numbers is:" + c);
        }

        //target file 2
        public void Multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Mulitplication of two numbers is:" + c);
        }        
    }

    //delegate
    public delegate void MyDelegateType(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            //MyDelegateType md = new MyDelegateType(s.Add);
            MyDelegateType md;
            
            //add ref of first target method
            md = s.Add;

            //add ref of second method. -> use '+' after delagte reference varibale, to chain it.
            md += s.Multiply;

            //invoke both target method -> 1.Add, 2.Muliply
            md.Invoke(10, 20);


            Console.ReadLine();
        }
    }
}
