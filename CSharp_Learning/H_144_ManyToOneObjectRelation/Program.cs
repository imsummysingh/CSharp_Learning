using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Many to One Object Relation Example
namespace H_144_ManyToOneObjectRelation
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }

        public Department dept { get; set; }
    }

    class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Three employees in the same department
            Employee e1 = new Employee() { EmployeeId = 101, EmployeeName = "Ranjeet", Email = "rjeet@gmail.com" };
            Employee e2 = new Employee() { EmployeeId = 102, EmployeeName = "Vicky", Email = "vicky@gmail.com" };
            Employee e3 = new Employee() { EmployeeId = 103, EmployeeName = "Mani", Email = "manisah@gmail.com" };

            //create object of the department class
            Department department = new Department() { DepartmentId = 10, DepartmentName = "IT" };

            //Mant to One object relation
            e1.dept = department;
            e2.dept = department;
            e3.dept = department;

            //Read the data
            Console.WriteLine("Employee Details:");

            Console.WriteLine("Employee 1");
            Console.WriteLine("Employee ID: "+e1.EmployeeId);
            Console.WriteLine("Employee Name: "+e1.EmployeeName);
            Console.WriteLine("Employee Email: "+e1.Email);
            Console.WriteLine("Employee Branch ID: " + e1.dept.DepartmentId);
            Console.WriteLine("Employee Branch Name: "+e1.dept.DepartmentName);

            Console.WriteLine();
            Console.WriteLine("Employee 2");
            Console.WriteLine("Employee ID: " + e2.EmployeeId);
            Console.WriteLine("Employee Name: " + e2.EmployeeName);
            Console.WriteLine("Employee Email: " + e2.Email);
            Console.WriteLine("Employee Branch ID: " + e2.dept.DepartmentId);
            Console.WriteLine("Employee Branch Name: " + e2.dept.DepartmentName);

            Console.WriteLine();
            Console.WriteLine("Employee 3");
            Console.WriteLine("Employee ID: " + e3.EmployeeId);
            Console.WriteLine("Employee Name: " + e3.EmployeeName);
            Console.WriteLine("Employee Email: " + e3.Email);
            Console.WriteLine("Employee Branch ID: " + e3.dept.DepartmentId);
            Console.WriteLine("Employee Branch Name: " + e3.dept.DepartmentName);

            Console.ReadLine();
        }
    }
}
