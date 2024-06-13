using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Conatins method example in collection
namespace H_122_ContainsMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            //contains -> Returns true/false
            Console.WriteLine(myList.Contains(40)); //true
            Console.WriteLine(myList.Contains(76)); //false

            Console.ReadLine();
        }
    }
}
