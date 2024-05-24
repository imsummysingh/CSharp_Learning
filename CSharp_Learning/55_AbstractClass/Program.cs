using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Abstract class Example
namespace _55_AbstractClass
{
    //Class Employee - Parent Class
    //Making parent class as abstract class
    abstract class Employee
    {
        //fields
        private int _empId;
        private string _empName;
        private string _location;

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
    class Manager : Employee        // inheriting from parent class with ":"
    {
        //field
        private string _departmentName;

        //properties
        public string DepartmentName
        {
            set
            {
                _departmentName = value;
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
    }

    //Class SalesMan -> child class of Employee
    class SalesMan : Employee
    {
        //field
        private string _region;

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
    class Program
    {
        //Only way to use the abstarct class, is by craeating object of the child class either Manager or Salesman.
        //Because through the child class object i.e. Manager class's object, you can access the fields, proeprties, methods of the parent class.
       //eg: EMpId, EMpName, Location are the members of the parent class's right.
        static void Main(string[] args)
        {
            //creating object of Employee
            //Employee emp = new Employee();      //-> cannot create instance of the abstract class.

            //Creating object of Manager
            Manager mgr = new Manager();
            mgr.EmpId = 101;
            mgr.EmpName = "Ranjeet";
            mgr.Location = "Bangalore";
            mgr.DepartmentName = "IT";
            Console.WriteLine("\nObject of Child Class ---> Manager");
            Console.WriteLine(mgr.EmpId);
            Console.WriteLine(mgr.EmpName);
            Console.WriteLine(mgr.Location);
            Console.WriteLine(mgr.DepartmentName);
            Console.WriteLine(mgr.GetTotalSalesOfTheYear());


            //Creating object of salesman
            SalesMan sm = new SalesMan();
            sm.EmpId = 102;
            sm.EmpName = "Vicky";
            sm.Location = "Leeds";
            sm.Region = "United Kingdom";
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
