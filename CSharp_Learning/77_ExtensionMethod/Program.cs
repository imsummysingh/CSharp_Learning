using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Extension method Example
namespace _77_ExtensionMethod
{
    //target class
    class Product
    {
        //properties
        public double ProductCost { get; set; }
        public double DiscountPercenatge { get; set; }
    }

    //extension class
    static class ProductExtension
    {
        //extension method
        public static double GetDiscount(this Product product)  //passing the className as parameter with this keyword
        {
            return product.ProductCost * product.DiscountPercenatge / 100;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product() { ProductCost = 1000, DiscountPercenatge = 10 };
            Console.WriteLine(p.GetDiscount());     //100

            Console.ReadLine();
        }
    }
}
