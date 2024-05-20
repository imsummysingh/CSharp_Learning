using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example of default parameter modifier
namespace _24_DefaultModifier
{
    class Program
    {
        public void GetAge(int age)     //paramater is age
        {
            Console.WriteLine("The age is:" + age);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            //we are passing 28 as an argument to the GetAge method, which will be passed to getAge() method as parameter
            p.GetAge(28);
            Console.ReadLine();
        }
    }
}
