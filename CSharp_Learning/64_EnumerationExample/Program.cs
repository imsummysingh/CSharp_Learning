using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Enumeration Example
namespace _64_EnumerationExample
{
    class Person
    {
        public string PersonName { get; set; }
        public string Email { get; set; }
        public AgeGroupEnumeration AgeGroup { get; set; }

    }

    //Enumeration for age group - User can assign one of these values only and not others to the property abover
    public enum AgeGroupEnumeration
    {
        Child,
        Teenager,
        Adult,
        Senior
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.PersonName = "Ranjeet";
            p.Email = "ranjo@gmail.com";
            p.AgeGroup = AgeGroupEnumeration.Adult;

            Console.WriteLine(p.PersonName);
            Console.WriteLine(p.Email);
            Console.WriteLine(p.AgeGroup);

            Console.ReadLine();
        }
    }
}
