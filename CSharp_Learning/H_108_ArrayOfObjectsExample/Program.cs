using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Array of Objects Example
namespace H_108_ArrayOfObjectsExample
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //objects of Employee
            Employee e1 = new Employee() { EmpId = 101, EmpName = "Ranjeet" };
            Employee e2 = new Employee() { EmpId = 102, EmpName = "Vicky" };
            Employee e3 = new Employee() { EmpId = 103, EmpName = "Mani" };

            //create array of objects ->Datat type is employee because we have to store the reference of Employee Type.
            
            //way 1
            //Employee[] e = new Employee[] { new Employee() { EmpId = 101, EmpName = "Ranjeet" },
            //                                new Employee() { EmpId = 102, EmpName = "Vicky" },
            //                                new Employee() { EmpId = 103, EmpName = "Mani" }};
            
            //way 2
            Employee[] emp = new Employee[] { e1, e2, e3 };

            //foreach loop for array of objects
            Console.WriteLine("Employee Details are:");
            foreach (Employee empItem in emp)
            {                
                Console.WriteLine(empItem.EmpId);
                Console.WriteLine(empItem.EmpName);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
