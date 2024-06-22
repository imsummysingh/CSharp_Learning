using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//using string methods to convert strings example
namespace _02_ConvertingString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Developer";           
            

            Console.WriteLine(str);

            //uppercase
            Console.WriteLine(str.ToUpper());   //DEVELOPER

            //lowercase
            Console.WriteLine(str.ToLower());   //developer

            //substring ->Gets a part of the same string
            Console.WriteLine(str.Substring(2));    //veloper
            Console.WriteLine(str.Substring(2, 3)); //vel


            //Replace
            Console.WriteLine(str.Replace("e", "x"));   //Dxvxlopxr


            //Split
            Console.WriteLine();
            string message = "How are you";
            string[] newmsg = message.Split(' ');
            foreach(string m in newmsg)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            //Trim
            string trimMsg = "    heloo     ";
            Console.WriteLine("Before Trim:"+trimMsg);     //    heloo     
            Console.WriteLine("After Trim:" + trimMsg.Trim());
            Console.WriteLine();

            //ToCharArray()
            char[] charArray = str.ToCharArray();
            foreach(char i in charArray)
            {
                Console.WriteLine(i);
            }


            //Join Method
            string[] words = new string[] { "Hey", "Hello", "Hi", "Hola" };
            string str_join = string.Join("-", words);
            Console.WriteLine(str_join);


            Console.ReadLine();
        }
    }
}
