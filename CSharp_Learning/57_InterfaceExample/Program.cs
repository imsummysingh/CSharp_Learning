using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//interface Example
namespace _57_InterfaceExample
{
    //Interface Employee
    interface IEmployee
    {
        //abstract methods
        string GetHealthInsuranceAmount();

        //Properties ->auto-implemented Properties
        int EmpId { get; set; }
        string EmpName { get; set; }
        string Location { get; set; }
    }

    //Class Manager which will Inherit the Interface EMployee
    class Manager : IEmployee
    {
        //declaring fields as private because these are required for properties
        private int _empId;
        private string _empName;
        private string _location;

        //Properties
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

        //Implementing Interface Method in the child class
        public string GetHealthInsuranceAmount()
        {
            return "Health Insurance Amount for Manager is:" + 5000;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating object for manager class
            Manager mgr = new Manager();
            mgr.EmpId = 101;
            mgr.EmpName = "Summy";
            mgr.Location = "Gurgaon";
            Console.WriteLine("Interface Implementation \n");
            Console.WriteLine(mgr.EmpId);
            Console.WriteLine(mgr.EmpName);
            Console.WriteLine(mgr.Location);
            Console.WriteLine(mgr.GetHealthInsuranceAmount());

            Console.ReadLine();
        }
    }
}
