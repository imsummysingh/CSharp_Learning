using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Auto-Implemented Properties Initializer Example
namespace _46_AutoImplementedPropertiesIntializer
{
    class Employee
    {
        //mprivate fields
        private int _empId;
        private string _empName;
        private string _jobProfile;
        private double _salary;
        private double _tax;

        //Instance property for empId
        public int EmpId
        {
            set
            {
                //checking validation before inserting the value into the field
                if (value >= 100)
                {
                    _empId = value;
                }
            }
            get
            {
                return _empId;
            }
        }

        //Instance property for EmpName
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

        //Instance property for Job Profile
        public string JobProfile
        {
            set
            {
                _jobProfile = value;
            }
            get
            {
                return _jobProfile;
            }
        }

        //readonly property
        public double Salary
        {
            get
            {
                return _salary;
            }
        }

        //Write only property
        public double Tax
        {
            set
            {
                _tax = value;
            }
        }

        //Method for calculating tax
        public double CalculateTax()
        {
            double t = Salary - _tax;
            return t;
        }

        //Auto-Implemented Properties -> or -> automatic properties
        //we will not create any private field for it, it will create that automatically by it's own
        public string NativePlace { get; set; }

        //Auto-Implemented Properties Intializer
        //we initialize the value at the time of declaration, and we can also override it later on
        public string LivingPlace { get; set; } = "Gurgaon";

        //Constructor
        public Employee()
        {
            this._salary = 100000;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.EmpId = 101;
            e.EmpName = "Summy Singh";
            e.JobProfile = "Full Stack Developer";
            e.Tax = 10;
            e.NativePlace = "Daman";   

            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee Id:" + e.EmpId);
            Console.WriteLine("Employee Name:" + e.EmpName);
            Console.WriteLine("Job Profile:" + e.JobProfile);
            Console.WriteLine("Salary is:" + e.Salary);
            Console.WriteLine("After Tax Amount is:" + e.CalculateTax());
            Console.WriteLine("Native Place is:" + e.NativePlace);
            Console.WriteLine("Living Place is:" + e.LivingPlace);

            Console.ReadLine();
        }
    }
}
