using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Default paramater example
namespace _21_DefaultParameter
{
    class Program
    {
        public int _age;     
        public int GetAge(int age=28)   //default age 28 will be taken
        {
            _age = age;         
            return _age;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetAge();     //no value is passed, so default value will be taken.
            Console.WriteLine("The default age is:" + p._age);      //28
            
            Program p2 = new Program();
            p2.GetAge(18);
            Console.WriteLine("The value passed as age is:" + p2._age);     //18
            Console.ReadLine();
        }
    }
}
