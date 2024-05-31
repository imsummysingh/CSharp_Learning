using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_PartialMethodExample
{
    public partial class Product
    {
        //public method for partial method calling
        public void CallGetClass()
        {
            //calling the private partial method in the public method to  be accessible in the main class
            GetClassName();
        }
    }
}
