using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_PartialMethodExample
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
            p.CallGetClass();

            Console.ReadLine();
        }
    }
}
