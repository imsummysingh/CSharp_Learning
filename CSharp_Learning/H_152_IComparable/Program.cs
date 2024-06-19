using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//IComparable Example
namespace H_152_IComparable
{
    class Employee:IComparable
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }

        public int CompareTo(object other)
        {
            Employee otherEmp = (Employee)other;
            Console.WriteLine(this.EmpName + "," + otherEmp.EmpName);
            return this.EmpName.CompareTo(otherEmp.EmpName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<int> list = new List<int>() { 87, 12, 3, 86, 64 };
            list.Sort();
            Console.WriteLine("Sorted List:");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpId=103,EmpName="Ranjeet",Job="Developer"},
                new Employee(){EmpId=102,EmpName="Vicky",Job="DevOps"},
                new Employee(){EmpId=105,EmpName="Vishal", Job="Testing"},
                new Employee(){EmpId=100,EmpName="Mani", Job="Cloud"}
            };

            //employees.Sort(); -> will not able to sort of employee object, or any object type. Need to implement IComparable Interface
            foreach(Employee item in employees)
            {
                Console.WriteLine(item.EmpId + " ," + item.EmpName + ", " + item.Job);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
