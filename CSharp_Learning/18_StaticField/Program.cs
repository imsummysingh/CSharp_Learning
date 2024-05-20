using _18_StaticFieldLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Static field example
namespace _18_StaticField
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating reference variable;
            Product p1, p2;

            //Creating objects
            p1 = new Product();     //Initial value for the fields in this object will be 0 & null because of default values
            Product.TotalProduct++; //1     //accessing static field with class name and incrementing it's value form 0 to 1 in the class memory
            
            p2 = new Product();
            Product.TotalProduct++; //2 //the value will be updated to 2.



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
            Console.WriteLine("Product Cost" +p1.cost);

            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            Console.WriteLine("Product Id:" + p2.productId);
            Console.WriteLine("Product Name:" + p2.productName);
            Console.WriteLine("Product Cost" +p2.cost);

            Console.WriteLine();

            Console.WriteLine("Static Field Value:");
            Console.WriteLine("Total No. Of Products:" +Product.TotalProduct); //will be access with classname.fieldname
            //Total product will not be stored in the object, but in the class memory individually

            Console.ReadLine();
        }
    }
}
