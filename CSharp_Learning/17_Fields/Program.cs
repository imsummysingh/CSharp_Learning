using _17_FieldClassLibraryExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Field example, fetching fields from Field Library class
namespace _17_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating reference variable;
            Product p1, p2;

            //Creating objects
            p1 = new Product();     //Initial value for the fields in this object will be 0 & null because of default values
            p2 = new Product();

            //Setting value for the field for the particular object
            p1.productId = 101;
            p1.productName = "iPhone14";
            p1.cost = 75000;

            p2.productId = 102;
            p2.productName = "iPad";
            p2.cost = 56000;

            //Reading data from the object
            Console.WriteLine("Product 1 Details:");
            Console.WriteLine("Product Id:" + p1.productId);
            Console.WriteLine("Product Name:" + p1.productName);
            Console.WriteLine("Product Cost", +p1.cost);

            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            Console.WriteLine("Product Id:" + p2.productId);
            Console.WriteLine("Product Name:" + p2.productName);
            Console.WriteLine("Product Cost", +p2.cost);

            Console.ReadLine();

        }
    }
}
