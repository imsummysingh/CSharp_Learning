using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Encapsulation example with getter and setter
namespace _20_Encapsulation_Ex1
{
    class Program
    {
        //Fields- making the field as private
        private int productId;
        private string productName;
        
        //making set and get method as public and that way we can access it.
        //Set method for ProductId
        public void SetProductId(int value)
        {
            productId = value;
        }
        //Get method for ProductId
        public int GetProductId()
        {
            return productId;
        }

        //Set method for ProductName
        public void SetProductName(string value)
        {
            productName = value;
        }
        //Get method for productname
        public string GetProductName()
        {
            return productName;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program();

            p1.SetProductId(101);
            p1.SetProductName("iPhone14");

            p2.SetProductId(102);
            p2.SetProductName("iPadAir");

            Console.WriteLine("Product Id for Object 1 is:" +p1.GetProductId());
            Console.WriteLine("Product Name for Object 1 is:" +p1.GetProductName());

            Console.WriteLine();

            Console.WriteLine("Product Id for Object 2 is:" +p2.GetProductId());
            Console.WriteLine("Product Name for Object 2 is:" +p2.GetProductName());

            Console.ReadLine();
        }
    }
}
