using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FirstProgram
{
    //class because, every method should be a part of a class
    class FirstProgram
    {
        //Static because it can be executed without creating an object of the main method by the CLR
        //Void because it should not return any value
        static void Main()
        {
            Console.WriteLine("Hello, this is the first program");
            Console.ReadLine();
        }
    }
}
