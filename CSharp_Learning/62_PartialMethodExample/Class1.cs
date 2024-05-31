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
        private int _productId;

        //public property
        public int ProductId
        {
            set
            {
                _productId = value;
            }
            get
            {
                return _productId;
            }
        }

        //Declaring method
        partial void GetClassName();
    }
}
