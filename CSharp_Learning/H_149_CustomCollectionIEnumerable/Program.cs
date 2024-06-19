using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Custom Collection example with IEnumerable
namespace H_149_CustomCollectionIEnumerable
{
    enum TypeOfCustomer
    {
        RegularCustomer, VIPCustomer
    }
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public TypeOfCustomer CustomerType { get; set; }
    }


    //custome collection class
    class CustomersList : IEnumerable<Customer>
    {
        private List<Customer> customers = new List<Customer>()
        {
            new Customer(){CustomerId=101, CustomerName="Ranjeet", Email="rjeet@gmail.com", CustomerType=TypeOfCustomer.RegularCustomer},
            new Customer(){CustomerId=102, CustomerName="Vicky", Email="vicky@gmail.com", CustomerType=TypeOfCustomer.VIPCustomer},
            new Customer(){CustomerId=103, CustomerName="Mani", Email="mani@gmail.com", CustomerType=TypeOfCustomer.RegularCustomer}
        };

        //implementing IEnumerable.GetEnumerator()
        IEnumerator IEnumerable.GetEnumerator()
        {
            //yield return customers[0];
            //yield return customers[1];
            //yield return customers[2];

            //for (int i = 0; i < customers.Count; i++)
            //{
            //    yield return customers[i];
            //}

            return this.GetEnumerator();
        }

        //Implementing IEnumerable<T>.GetEnumerator() ->This is imp
        public IEnumerator<Customer> GetEnumerator()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i];
            }
        } 

        //additional method which can simplify the work 
        //here modifying the add method
        public void Add(Customer cust)
        {
            customers.Add(cust);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomersList customersList = new CustomersList();

            //adding new customer
            Customer c1 = new Customer() { CustomerId = 104, CustomerName = "Vishal", Email = "vishalvishal@gmail.com", CustomerType = TypeOfCustomer.RegularCustomer };

            customersList.Add(c1);


            foreach (Customer customer in customersList)
            {
                Console.WriteLine(customer.CustomerId);
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.CustomerType);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
