using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Collection of Object example
namespace H_141_CollectionOfObjects
{
    class Product
    {
        //properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime DateofManufacturing { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty collection
            List<Product> products = new List<Product>();

            //loop to read data from user
            string choice;
            do
            {
                Console.Write("Enter Prodcut ID:");
                int pid = int.Parse(Console.ReadLine());

                Console.Write("Enter Prodcut Name:");
                string pname = Console.ReadLine();

                Console.Write("Enter Price:");
                double pprice = double.Parse(Console.ReadLine());

                Console.Write("Enter Manufacturing Date:");
                DateTime pdom = DateTime.Parse(Console.ReadLine());

                //create a new object of Product class
                Product product = new Product() { ProductID = pid, ProductName = pname, Price = pprice, DateofManufacturing = pdom };


                //add product object to the collection
                products.Add(product);


                //Ask the user to continue
                Console.WriteLine("Product Added. \n");
                Console.WriteLine("Do you want to add another Product? (Yes/No)");
                choice = Console.ReadLine();


            } while (choice != "No" && choice != "no" && choice != "n" && choice!="N");


            //for each loop to access the collection
            Console.WriteLine("\nProducts:");
            foreach(Product item in products)
            {
                Console.WriteLine(item.ProductID + ", " + item.ProductName + ", " + item.Price + ", " + item.DateofManufacturing.ToShortDateString());
            }

            Console.ReadLine();
        }
    }
}
