using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Constructor Example
namespace _38_ConstructorExample
{
    class Employee
    {
        //fields
        public int empId;
        public string empName;
        public string jobProfile;

        //constructor

        //Way 1
        //public Employee(int _empId, string _empName, string _jobProfile)
        //{
        //    empId = _empId;
        //    empName = _empName;
        //    jobProfile = _jobProfile;
        //}

        //Way 2- using this keyword
        public Employee(int empId, string empName, string jobProfile)
        {
            //this will refer to the current object, and will assign the fields values to that current object it is pointing to
            this.empId = empId;
            this.empName = empName;
            this.jobProfile = jobProfile;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creating objects
            //we will have to pass the parameters while creating the object
            Employee e1 = new Employee(101, "Summy","Full Stack Developer");    
            Employee e2 = new Employee(102, "Vicky", "DevOps");

            Console.WriteLine("Employee 1 Details:");
            Console.WriteLine("Employee Id:" + e1.empId);
            Console.WriteLine("Employee Name:" + e1.empName);
            Console.WriteLine("Job Profile:" + e1.jobProfile);

            Console.WriteLine("Employee 2 Details:");
            Console.WriteLine("Employee Id:" + e2.empId);
            Console.WriteLine("Employee Name:" + e2.empName);
            Console.WriteLine("Job Profile:" + e2.jobProfile);

            Console.ReadLine();
        }
    }
}
