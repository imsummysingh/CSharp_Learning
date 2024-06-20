using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Deconstruction Example
namespace H_158_Deconstructing
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
            //Deconstruction -> these three are now normal regular variables of the current working main method.
            (int customerID, string customerName, string email)  = c.GetCustomerDetails();

            //the fields are not read only, means can be modified.
            Console.WriteLine(customerID);
            Console.WriteLine(customerName);
            Console.WriteLine(email);

            Console.ReadLine();
        }
    }
}
