using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Static fild library example
namespace _18_StaticFieldLibrary
{
    public class Product
    {
        //Fields
        public int productId;
        public string productName;
        public double cost;
        public static int TotalProduct; //static field

        //can access the sttaic method within the same class without the class name.
        public void StaticMethod()
        {
            TotalProduct = 0;
            Product.TotalProduct = 0;
        }
    }
}
