using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Goto statement label
namespace _15_GotoStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("USA");
            Console.WriteLine("UK");
            Console.WriteLine("Australia");
            Console.WriteLine("India");
            goto mycountry;
            Console.WriteLine("Pakistan");
            Console.WriteLine("Spain");
            Console.WriteLine("Brazil");
            mycountry:      //USA, UK,Australia, India, Turkey, Indonesia
            Console.WriteLine("Turkey");
            Console.WriteLine("Indonesia");


            Console.ReadLine();
        }
    }
}
