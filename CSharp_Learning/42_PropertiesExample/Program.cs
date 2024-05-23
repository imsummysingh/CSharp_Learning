using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Properties Example with set and get accessors.
namespace _42_PropertiesExample
{
    class Employee
    {
        //mprivate fields
        private int _empId;
        private string _empName;
        private string _jobProfile;

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


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.EmpId = 101;
            e.EmpName = "Summy Singh";
            e.JobProfile = "Full Stack Developer";

            Console.WriteLine("Employee Details:");
            Console.WriteLine("Employee Id:" + e.EmpId);
            Console.WriteLine("Employee Name:" + e.EmpName);
            Console.WriteLine("Job Profile:" + e.JobProfile);

            Console.ReadLine();
        }
    }
}
