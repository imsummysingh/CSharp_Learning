using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_PartialClassExample
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
    }
}
