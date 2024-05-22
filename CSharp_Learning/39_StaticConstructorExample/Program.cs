using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Static Constructor Example
namespace _39_StaticConstructorExample
{
    class Employee
    {
        //fields
        public static string companyName;
        public int empId;
        public string empName;
        public string jobProfile;

        //Instance Constructor
        public Employee(int empId, string empName, string jobProfile)
        {
            //this will refer to the current object, and will assign the fields values to that current object it is pointing to
            this.empId = empId;
            this.empName = empName;
            this.jobProfile = jobProfile;
        }

        //Static constructor ->
        //1.public by default
        //2. cannot have any parameter
        //3. cannot have any return type
        static Employee()
        {
            companyName = "DXC Technology";
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creating objects
            //we will have to pass the parameters while creating the object
            Employee e1 = new Employee(101, "Summy", "Full Stack Developer");
            Employee e2 = new Employee(102, "Vicky", "DevOps");

            Console.WriteLine(Employee.companyName);

            Console.WriteLine("\nEmployee 1 Details:");
            Console.WriteLine("Employee Id:" + e1.empId);
            Console.WriteLine("Employee Name:" + e1.empName);
            Console.WriteLine("Job Profile:" + e1.jobProfile);

            Console.WriteLine();

            Console.WriteLine("Employee 2 Details:");
            Console.WriteLine("Employee Id:" + e2.empId);
            Console.WriteLine("Employee Name:" + e2.empName);
            Console.WriteLine("Job Profile:" + e2.jobProfile);

            Console.ReadLine();
        }
    }
}
