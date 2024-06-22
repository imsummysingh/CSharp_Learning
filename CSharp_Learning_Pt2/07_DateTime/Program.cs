using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Date Time Example
namespace _07_DateTime
{
    class Person
    {
        public string PersonName { get; set; }
        public DateTime DOB { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.PersonName = "Ranjeet";
            p1.DOB = DateTime.Parse("30-01-1995 11:58:59.999 am");


            Console.WriteLine(p1.PersonName);
            Console.WriteLine(p1.DOB);
            Console.WriteLine(p1.DOB.ToString());

            Console.ReadLine();
        }
    }
}
