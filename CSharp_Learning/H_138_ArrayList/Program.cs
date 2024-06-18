using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ArrayList Example
namespace H_138_ArrayList
{
    class Sample
    {
        public int GetNumber()
        {
            return 10;
        }

        public double GetAnotherNumber()
        {
            return 10.7;
        }

        public string GetMessage()
        {
            return "Hello";
        }

        public Employee GetEmployee()
        {
            return new Employee() { EmployeeName = "Ranjeet" };
        }
    }

    class Employee
    {
        public string EmployeeName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create object of ArrayList
            ArrayList arrayList = new ArrayList() { 100, 'A' };


            Sample s = new Sample();


            //Add
            arrayList.Add(s.GetNumber());
            arrayList.Add(s.GetAnotherNumber());
            arrayList.Add(s.GetMessage());
            arrayList.Add(s.GetEmployee());


            //foreach for accessing arraylist
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine();

            //foreach ->For empname and not class name
            foreach (var item in arrayList)
            {
                if(item is Employee emp)
                {
                    Console.WriteLine(emp.EmployeeName);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }


            Console.ReadLine();
        }
    }
}
