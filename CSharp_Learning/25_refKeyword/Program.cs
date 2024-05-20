using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example of ref parameter modifier
namespace _25_refKeyword
{
    class Program
    {
        public void Sum(ref int a)
        {
            Console.WriteLine("The value of argument passed to the Parameter:" + a);        //5
            a=a + 5;
            Console.WriteLine("The value of argument after being modified by the parameter:" + a);     //10
        }
        static void Main(string[] args)
        {
            int num = 5;
            Program p = new Program();
            p.Sum(ref num);
            Console.WriteLine("The value of Num after being modified by Parameter is:" +num);       //10
            Console.ReadLine();
        }
    }
}
