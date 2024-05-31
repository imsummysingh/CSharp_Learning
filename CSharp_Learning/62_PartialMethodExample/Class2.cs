using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_PartialMethodExample
{
    public partial class Product
    {
        //private field
        private string _productName;

        //public property
        public string ProductName
        {
            set
            {
                _productName = value;
            }
            get
            {
                return _productName;
            }
        }

        //Implementing method of partial class1
        partial void GetClassName()
        {
            Console.WriteLine("Implementing the partial class1 method in Partial class 2");
        }
    }
}
