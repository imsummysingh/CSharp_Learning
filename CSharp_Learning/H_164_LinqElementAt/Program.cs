using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Linq ElementAt & ElementOrDefault Example
namespace H_164_LinqElementAt
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

            //ElementAt
            Employee eF = emp.ElementAt(3);
            Console.WriteLine("\nWith ElementAt:");
            Console.WriteLine(eF.EmpId + ", " + eF.EmpName);


            //ElementOrDefault -> Will return null, if no element found at that Index.
            //will return null
            Console.WriteLine("\nWith ElementOrDefault:");
            Employee eE1 = emp.ElementAtOrDefault(5);
            //Console.WriteLine(eE1.EmpId + ", " + eE1.EmpName);
            if (eE1 != null)
            {
                Console.WriteLine(eE1.EmpId + ", " + eE1.EmpName);
            }
            else
            {
                Console.WriteLine("No result found");
            }



            Console.ReadLine();
        }
    }
}
