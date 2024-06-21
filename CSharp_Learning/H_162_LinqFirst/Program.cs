using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Linq First & FirstorDefault Example
namespace H_162_LinqFirst
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

            //where -> to make it work like first
            Console.WriteLine("With Where:");
            List<Employee> filteredEmp = emp.Where(e => e.Job == "Cloud").ToList();
            Console.WriteLine(filteredEmp[0].EmpId + ", " + filteredEmp[0].EmpName);

            //First
            Employee eF=emp.First(e => e.Job == "Cloud");
            Console.WriteLine("\nWith First:");
            Console.WriteLine(eF.EmpId + ", " + eF.EmpName);


            //First with no matching value
            //Sequence contains no matching element'
            //Employee eE1 = emp.First(e => e.Job == "Security"); 
            //Console.WriteLine(eF.EmpId + ", " + eF.EmpName);


            //FirstorDefault -> Will return null, if no mathcing element found.
            //will return null
            Console.WriteLine("\nWith FirstorDefault:");
            Employee eE1 = emp.FirstOrDefault(e => e.Job == "Security");
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
