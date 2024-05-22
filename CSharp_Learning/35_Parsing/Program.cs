using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Parsing Example - No Space, No Alphabets, No Special characters
namespace _35_Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //String value
            string a = "100";
            string c = "Hello";

            //int
            int b, d;

            //convert string 'a' to int 'b'
            b = int.Parse(a);

            //converting string 'c' to int 'd'
            //d = int.Parse(c);       //can't convert - Input string was not in correct format

            Console.WriteLine("The value of string A is:" + a);     //100
            Console.WriteLine("The value of Integer B after Parsing is:" + b);  //100

            //Console.WriteLine("The value of string C is:" + c);     
           // Console.WriteLine("The value of Integer D after Parsing is:" + d);  

            Console.ReadLine();
        }
    }
}
