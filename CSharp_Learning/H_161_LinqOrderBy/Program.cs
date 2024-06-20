using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//linq order by example
namespace H_161_LinqOrderBy
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //collection of objects
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){EmpId=101, EmpName="Ranjeet", Job="Developer", Salary=90000},
                new Employee(){EmpId=102, EmpName="Vishal", Job="Testing", Salary=110000},
                new Employee(){EmpId=103, EmpName="Mani", Job="Cloud",Salary=78000},
                new Employee(){EmpId=104, EmpName="Vicky",Job="DevOps", Salary=120000},
                new Employee(){EmpId=105, EmpName="Govind", Job="Cloud", Salary=6000},
            };

            //orderby ->Ascending order
            //return data in IOrderEnumerable
            //IEnumerable<Employee> sortedEmp = emp.OrderBy(e => e.EmpName);
            IOrderedEnumerable<Employee> sortedEmp=emp.OrderBy(e => e.EmpName);
            Console.WriteLine("OrderBy Name:");
            foreach(Employee e in sortedEmp)
            {
                Console.WriteLine(e.EmpId + ", " + e.EmpName + ", " + e.Job + ", " + e.Salary);
            }

            IOrderedEnumerable<Employee> sortedEmpDesc = emp.OrderByDescending(e => e.EmpName);
            Console.WriteLine("\nOrderBy Name Descending Order:");
            foreach (Employee e in sortedEmpDesc)
            {
                Console.WriteLine(e.EmpId + ", " + e.EmpName + ", " + e.Job + ", " + e.Salary);
            }


            //ThenBy
            IOrderedEnumerable<Employee> sortthenEmp = emp.OrderBy(e => e.Job).ThenBy(e=>e.Salary);
            Console.WriteLine("\nOrderBy Job & ThenBySalary:");
            foreach (Employee e in sortthenEmp)
            {
                Console.WriteLine(e.EmpId + ", " + e.EmpName + ", " + e.Job + ", " + e.Salary);
            }



            Console.ReadLine();
        }
    }
}
