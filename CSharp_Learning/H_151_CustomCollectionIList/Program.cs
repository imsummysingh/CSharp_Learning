using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Custom Collection Example with IList
namespace H_151_CustomCollectionIList
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
    class CustomersList : IList<Customer>
    {
        private List<Customer> customers = new List<Customer>()
        {
            new Customer(){CustomerId=101, CustomerName="Ranjeet", Email="rjeet@gmail.com", CustomerType=TypeOfCustomer.RegularCustomer},
            new Customer(){CustomerId=102, CustomerName="Vicky", Email="vicky@gmail.com", CustomerType=TypeOfCustomer.VIPCustomer},
            new Customer(){CustomerId=103, CustomerName="Mani", Email="mani@gmail.com", CustomerType=TypeOfCustomer.RegularCustomer}
        };

        public int Count => customers.Count;

        //tells if we can modify or not the collection. if Yes, then false. if No, then true.
        public bool IsReadOnly => false;

        public Customer this[int index] 
        {
            get => customers[index];
            set => customers[index] = value;
        }

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

        //these are the method of Interface ICollection
        public void Clear()
        {
            customers.Clear();
        }

        public bool Contains(Customer item)
        {
            return customers.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            customers.CopyTo(array, arrayIndex);
        }

        public bool Remove(Customer item)
        {
            return customers.Remove(item);
        }

        //additional methods
        public Customer Find(Predicate<Customer> match)
        {
            return customers.Find(match);
        }

        public List<Customer> FindAll(Predicate<Customer> match)
        {
            return customers.FindAll(match);
        }

        public int IndexOf(Customer item)
        {
            return customers.IndexOf(item);
        }

        public void Insert(int index, Customer item)
        {
            if (index < 0)
            {
                Console.WriteLine("Invalid Index");
            }
            else
            {
                customers.Insert(index, item);
            }            
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Invalid Index");
            }
            else
            {
                customers.RemoveAt(index);
            }            
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

            Console.WriteLine("Total No: of CUstomers: " + customersList.Count);

            Console.ReadLine();
        }
    }
}
