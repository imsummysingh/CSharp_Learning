using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Runtime Polymorphism Example
namespace _58_RuntimePolymorphism
{   
    //Making parent class as absratct
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

        //abstract method
        public abstract string ReturnMessage();

    }

    //child class 1
    class Manager : Employee
    {
        public override string ReturnMessage()
        {
            return "Message from the Manager Class-> Child Class 1";
        }
    }

    //child class 2
    class SalesMan : Employee
    {
        public override string ReturnMessage()
        {
            return "Message from the SalesMan Class -> Child Class 2";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creating reference varibale for the parent
            Employee e;

            //creating obj for child class 1
            e = new Manager();
            e.EmpId = 101;
            e.EmpName = "Emp1";
            e.Location = "Gurgaon";
            Console.WriteLine(e.EmpId);
            Console.WriteLine(e.EmpName);
            Console.WriteLine(e.Location);
            Console.WriteLine(e.ReturnMessage());
            Console.WriteLine();

            //Creating obj for child class 2
            e = new SalesMan();
            e.EmpId = 102;
            e.EmpName = "Emp2";
            e.Location = "Noida";
            Console.WriteLine(e.EmpId);
            Console.WriteLine(e.EmpName);
            Console.WriteLine(e.Location);
            Console.WriteLine(e.ReturnMessage());
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
