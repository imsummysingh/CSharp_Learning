using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Linq example
namespace H_160_Linq
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //collection of objects
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){EmpId=101, EmpName="Ranjeet", Job="Developer", City="Bangalore"},
                new Employee(){EmpId=102, EmpName="Vishal", Job="Testing", City="Bangalore"},
                new Employee(){EmpId=103, EmpName="Mani", Job="Cloud",City="Gurgaon"},
                new Employee(){EmpId=104, EmpName="Vicky",Job="DevOps", City="Leeds"}
            };

            //linq query

            Console.WriteLine("Linq query to find Job profile as Developer");
            var result = emp.Where(e=>e.Job=="Developer");
            foreach(var item in result)
            {
                Console.WriteLine(item.EmpId+", "+item.EmpName+", "+item.Job+", "+item.City);
            }


            Console.WriteLine("\nLinq query to find emp living in Bangalore");
            //var empCity = emp.Where(e => e.City == "Bangalore");
            //IEnumerable<Employee> empCity = emp.Where(e => e.City == "Noida"); -> will give null
            IEnumerable<Employee> empCity = emp.Where(e => e.City == "Bangalore");
            foreach (var c in empCity)
            {
                Console.WriteLine(c.EmpId + ", " + c.EmpName + ", " + c.Job + ", " + c.City);
            }



            Console.ReadLine();
        }
    }
}
