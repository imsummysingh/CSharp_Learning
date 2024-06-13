using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//RemoveAll method example in collection
namespace H_118_RemoveAllMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 11,13, 17, 20, 23,27, 30, 33, 35,  36, 39, 40, 50, 60 };

            //RemoveAll -> with some condition
            myList.RemoveAll(n => n % 2 == 1); //remove odd no.s

            Console.WriteLine("Demonstrating RemoveAll method in List");
            foreach (int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
