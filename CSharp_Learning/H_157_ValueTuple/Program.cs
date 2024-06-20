using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Value Tuple Example
namespace H_157_ValueTuple
{
    class Customer
    {
        //the way we are passing value which will be returned, is Value Tuple
        public (int customerID, string customerName, string email) GetCustomerDetails()
        {
            return (101, "Ranjeet", "rkumar30@gmail.com");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            //get details
            //value Tuple
            (int customerID, string customerName, string email) cust = c.GetCustomerDetails();

            //the fields are not read only, means can be modified.
            Console.WriteLine(cust.customerID);
            Console.WriteLine(cust.customerName);
            Console.WriteLine(cust.email);

            Console.ReadLine();
        }
    }
}
