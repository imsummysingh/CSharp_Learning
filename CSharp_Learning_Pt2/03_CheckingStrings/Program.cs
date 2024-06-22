using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Checking string methods example
namespace _03_CheckingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //strings
            string str1 = "Universe";
            string str2 = "Universe";
            string str3 = "Hello";
            string str4 = str1;


            //equals
            Console.WriteLine("Equals");
            Console.WriteLine(str1.Equals(str2));   //true
            Console.WriteLine(str1.Equals(str3));   //false
            Console.WriteLine(str1.Equals(str4));   //true

            //StartsWith
            Console.WriteLine("\nStarts With");
            Console.WriteLine(str1.StartsWith("U"));    //true
            Console.WriteLine(str1.StartsWith("u"));    //false

            //Ends With
            Console.WriteLine("\nEnds With");
            Console.WriteLine(str1.EndsWith("e"));    //true
            Console.WriteLine(str1.EndsWith("E"));    //false

            //COntains
            Console.WriteLine("\nContains");
            Console.WriteLine(str1.Contains("r"));  //true


            //IndexOf
            Console.WriteLine("\nIndexOf");
            string email = "rkumar@gmail.com";
            Console.WriteLine(email.IndexOf("com"));    //13
            Console.WriteLine(email.IndexOf("com", 10));    //13

            //LastIndexOf
            Console.WriteLine("\nLast IndexOf");
            string msg = "Developer";
            Console.WriteLine(msg.LastIndexOf("e"));    //7


            //IsNullOrEmpty
            Console.WriteLine("\nIsNullOrEmpty");
            string input = null;
            //Static method, so will have to call using class name
            Console.WriteLine(string.IsNullOrEmpty(input)); //true


            Console.ReadLine();
        }
    }
}
