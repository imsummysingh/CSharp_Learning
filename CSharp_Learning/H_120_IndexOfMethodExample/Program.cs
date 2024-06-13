using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IndexOf method example in collection.
namespace H_120_IndexOfMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            //IndexOf
            //myList.IndexOf(40);

            Console.WriteLine(myList.IndexOf(40));      //3
            Console.WriteLine(myList.IndexOf(80,8));    //-1 -> Because the index is 7, and it's start index is 8
            Console.WriteLine(myList.IndexOf(80, 5));    //7
            Console.WriteLine(myList.IndexOf(42));      //-1

            Console.ReadLine();
        }
    }
}
