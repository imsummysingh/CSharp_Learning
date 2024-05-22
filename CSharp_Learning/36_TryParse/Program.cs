using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Try Parse Example
namespace _36_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //String value
            string a = "100";
            string aa = "Hello";

            //convert string 'a' to int 'b'
            //bool b = int.TryParse(a, out int n);  //true
            bool b = int.TryParse(aa, out int n);   //failed
            if (b == true)
            {
                Console.WriteLine("Conversion Successful");
                Console.WriteLine("The value of B after conversion through TryParse is:" + b);  //true
            }
            else
            {
                Console.WriteLine("Conversion Failed.");
            }

            Console.ReadLine();
        }
    }
}
