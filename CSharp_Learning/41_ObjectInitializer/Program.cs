using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Object Initializer Example 
namespace _41_ObjectInitializer
{
    //currently we don't have a constructor for empName and JobProfile, for that we will use object Initializer.
    class Employee
    {
        //fields
        public int empId;
        public string empName;
        public string jobProfile;

        //Paramater-less constructor
        public Employee()
        {
            Console.WriteLine("This is paramter less constructor\n");
        }

        //constructor with 1 paramater
        public Employee(string jobProfile)
        {
            Console.WriteLine("This is constructor with 1 paramater as Job Profile\n");
            this.jobProfile = jobProfile;
        }

        //constructor wuth 2 parameters
        public Employee(int empId, string empName)
        {
            Console.WriteLine("This is constructor with 2 paramaters\n");
            this.empId = empId;
            this.empName = empName;
        }

        //constructor with 3 paramaters
        public Employee(int empId, string empName, string jobProfile)
        {
            this.empId = empId;
            this.empName = empName;
            this.jobProfile = jobProfile;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //this will call the constructor with no paramaters
            Employee e = new Employee();


            //object for constructor with 1 paramaters
            Employee e1 = new Employee(".Net Developers Opening");
            Console.WriteLine("Employee 1 Details:");
            Console.WriteLine("Job Profile:" + e1.jobProfile);
            Console.WriteLine();

            //Object for constructor with 2 paramaters
            Employee e2 = new Employee(101, "Ranjeet");
            Console.WriteLine("Employee 2 Details:");
            Console.WriteLine("Employee Id:" + e2.empId);
            Console.WriteLine("Employee Name:" + e2.empName);
            Console.WriteLine();

            //Object for constructor with 3 paramaters
            Employee e3 = new Employee(102, "Vicky", "DevOps");
            Console.WriteLine("Employee 3 Details:");
            Console.WriteLine("Employee Id:" + e3.empId);
            Console.WriteLine("Employee Name:" + e3.empName);
            Console.WriteLine("Job Profile:" + e3.jobProfile);
            Console.WriteLine();

            //we don't have a constructor for empName and JobProfile, for that we will use object Initializer.
            //Pbject Initializer:
            //1. calling paramater less constructor
            //2. use {} for object initializer and specify in that what you want
            //3. new class---> constructor ----> Object Initializer
            Employee e4 = new Employee() { empName = "Vishal", jobProfile = "Automation Testing" };
            Console.WriteLine("Employee 4 Details Using Object Initilaizer:");
            Console.WriteLine("Employee Name:" + e4.empName);
            Console.WriteLine("Job Profile:" + e4.jobProfile);
            Console.WriteLine();

            Console.ReadLine();
        }

    }
}
