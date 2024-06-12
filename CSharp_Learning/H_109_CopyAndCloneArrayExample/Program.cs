using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CopyTo And Clone Example in Array
namespace H_109_CopyAndCloneArrayExample
{
    //model class
    class Employee
    {
        public string EmpName { get; set; }
        public string Role { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[]
            {
                new Employee(){EmpName="Ranjeet", Role="Developer"},
                new Employee(){EmpName="Vicky", Role="DevOps"},
                new Employee(){EmpName="Vishal", Role="Testing"}
            };

            //new array
            Employee[] paidEmp = new Employee[3];   //empty array with size 3

            //CopyTo
            emp.CopyTo(paidEmp, 0);     //0 is the start index

            //print array
            Console.WriteLine("CopyTo");
            foreach(Employee e in paidEmp)
            {
                if(!(e is null))
                {
                    Console.WriteLine("Name:" + e.EmpName);
                    Console.WriteLine("Role:" + e.Role);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Null Object");
                }
            }
            Console.WriteLine();


            //Clone
            Console.WriteLine("Clone");
            Employee[] highPaidEmp = (Employee[])emp.Clone();
            foreach(Employee e in highPaidEmp)
            {
                Console.WriteLine("Name:" + e.EmpName);
                Console.WriteLine("Role:" + e.Role);
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
