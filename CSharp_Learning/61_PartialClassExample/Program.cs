using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Partial class Example
namespace _61_PartialClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of partial class
            Product p = new Product();
            p.ProductId = 101;
            p.ProductName = "Apple iPad";

            Console.WriteLine("Working with partial class");
            Console.WriteLine(p.ProductId);
            Console.WriteLine(p.ProductName);

            Console.ReadLine();
        }
    }
}
