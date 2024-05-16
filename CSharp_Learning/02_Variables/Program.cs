using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Learning variables
namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 28;        //Integer (whole number) 
            double y = 5.2024; // Floating point number
            string name = "Summy";  //String - double quote
            char surname = 'S'; // character - single quote
            bool alive = true;

            //{} is used to concat the variable in the sentence, like +
            Console.WriteLine("Name is:{0}",name);
            Console.WriteLine("Surname strats with:{0}", surname);
            Console.WriteLine("Age is:{0}", age);
            Console.WriteLine("month and year is:{0}", y);
            Console.WriteLine("Is Alive?{0}", alive);
            Console.ReadLine();

        }
    }
}
