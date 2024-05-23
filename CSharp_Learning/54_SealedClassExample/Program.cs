using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sealed Class Example
namespace _54_SealedClassExample
{
    //Class Employee - Parent Class
    class Employee
    {
        //fields
        private int _empId;
        private string _empName;
        private string _location;

        //Constructor for parent class
        public Employee(int empId, string empName, string location)
        {
            this._empId = empId;
            this._empName = empName;
            this._location = location;
        }

        //Method -> Virtual for method overriding example
        public virtual string GetHealthInsuranceAmount()
        {
            return "Health Insurance Amount is: " + 5000;
        }

        //properties
        public int EmpId
        {
            set
            {
                _empId = value;
            }
            get
            {
                return _empId;
            }
        }

        public string EmpName
        {
            set
            {
                _empName = value;
            }
            get
            {
                return _empName;
            }
        }

        public string Location
        {
            set
            {
                _location = value;
            }
            get
            {
                return _location;
            }
        }
    }

    //Class Manager - Child Class inherit from Parent class Employee
    //Making Manager class as Sealed class
    sealed class Manager : Employee        // inheriting from parent class with ":"
    {
        //field
        private string _departmentName;

        //Constructor of the child class -> For parent class parameterized constructor.
        //The constructor of the child class, must receive the parameter of the child class and parent class fields also.
        public Manager(int empId, string empName, string location, string departmentName) : base(empId, empName, location)
        {
            _departmentName = departmentName;
        }

        //properties
        public string DepartmentName
        {
            set
            {
                this._departmentName = value;
            }
            get
            {
                return _departmentName;
            }
        }

        //method -> this will only be avaialble in the child class manager and not in the parent class Employee
        public long GetTotalSalesOfTheYear()
        {
            return 10000;
        }

        //Method- for base keyword
        public string GetFullDepartmentName()
        {
            return DepartmentName + " at " + base.Location;
        }

        //Method in child class-> for method overriding
        //will use 'override' keyword for overriding parent class method
        public override string GetHealthInsuranceAmount()
        {
            //first calling parent class method with base keyword, so we can extend the method later on.
            Console.WriteLine(base.GetHealthInsuranceAmount());
            return "Additional Health Insurance Amount is: " + 1500;
        }
    }

    //Class SalesMan -> child class of Employee
    class SalesMan : Employee
    {
        //field
        private string _region;

        //Constructor of the child class -> For parent class parameterized constructor.
        //The constructor of the child class, must receive the parameter of the child class and parent class fields also.
        public SalesMan(int empId, string empName, string location, string region) : base(empId, empName, location)
        {
            this._region = region;
        }

        //Property
        public string Region
        {
            set
            {
                _region = value;
            }
            get
            {
                return _region;
            }
        }

        //Method
        public long GetSalesOfTheCurrentMonth()
        {
            return 1000;
        }
    }

    //Making branchManager class  inherit from sealed class Manager
    //class BranchManager : Manager   //BranchManager cannot derive from SealedType 'Manager'
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of Employee
            Employee emp = new Employee(101, "Summy", "Gurgaon");
            Console.WriteLine("Object of Parent Class ---> Employee");
            Console.WriteLine(emp.EmpId);
            Console.WriteLine(emp.EmpName);
            Console.WriteLine(emp.Location);
            Console.WriteLine(emp.GetHealthInsuranceAmount());


            //Creating object of Manager
            Manager mgr = new Manager(101, "Ranjeet", "Bangalore", "IT");
            Console.WriteLine("\nObject of Child Class ---> Manager");
            Console.WriteLine(mgr.EmpId);
            Console.WriteLine(mgr.EmpName);
            Console.WriteLine(mgr.Location);
            Console.WriteLine(mgr.DepartmentName);
            Console.WriteLine(mgr.GetTotalSalesOfTheYear());
            Console.WriteLine(mgr.GetFullDepartmentName());
            Console.WriteLine(mgr.GetHealthInsuranceAmount());


            //Creating object of salesman
            SalesMan sm = new SalesMan(102, "Vicky", "Leeds", "United Kingdom");
            Console.WriteLine("\nObject of Child Class ---> SalesMan");
            Console.WriteLine(sm.EmpId);
            Console.WriteLine(sm.EmpName);
            Console.WriteLine(sm.Location);
            Console.WriteLine(sm.Region);
            Console.WriteLine(sm.GetSalesOfTheCurrentMonth());

            Console.ReadLine();
        }
    }
}
