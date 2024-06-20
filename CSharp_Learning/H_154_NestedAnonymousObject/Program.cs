using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nested Anonymous Object Example
namespace H_154_NestedAnonymousObject
{
    class Person
    {
        public string GetPersonName()
        {
            return "Ranjeet";
        }
        public int GetPersonAge()
        {
            return 29;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create object of person class
            Person p = new Person();

            //call the methods
            //p.GetPersonName();
            //p.GetPersonAge();


            //we can initialize person name and age into a single object using Anonymous object concept
            //nested anonymous object
            var person = new { PersonName = p.GetPersonName(), Age = p.GetPersonAge(), 
                Address = new { City="Gurgaon", State="Haryana"} };

            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address.City);
            Console.WriteLine(person.Address.State);

            Console.ReadLine();
        }
    }
}
