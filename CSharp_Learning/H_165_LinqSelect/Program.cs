using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Linq select Example
namespace H_165_LinqSelect
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    class Person
    {
        public string PersonName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //collection of objects
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){EmpId=101, EmpName="Ranjeet", Job="Developer", Salary=90000},
                new Employee(){EmpId=102, EmpName="Vishal", Job="Testing", Salary=110000},
                new Employee(){EmpId=103, EmpName="Mani", Job="Cloud",Salary=78000},
                new Employee(){EmpId=104, EmpName="Vicky",Job="DevOps", Salary=120000},
                new Employee(){EmpId=105, EmpName="Govind", Job="Cloud", Salary=6000},
            };

            //select
            //->it will produce the value which was given in lambda expression
            //IEnumerable<int> result = emp.Select(e => 10);
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);   //5 times->10, because there are 5 elements in emp object
            //}


            //select
            IEnumerable<Person> person=emp.Select(e => new Person() { PersonName=e.EmpName});
            foreach(Person p in person)
            {
                Console.WriteLine(p.PersonName);
            }


            Console.ReadLine();
        }
    }
}
