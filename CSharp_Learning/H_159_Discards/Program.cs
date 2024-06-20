using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Discards Example
namespace H_159_Discards
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
            //Discard -> let's skip email
            (int customerID, string customerName, _) = c.GetCustomerDetails();

            //the fields are not read only, means can be modified.
            Console.WriteLine(customerID);
            Console.WriteLine(customerName);

            Console.ReadLine();
        }
    }
}
