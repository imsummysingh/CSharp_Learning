using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Insert Method Example
namespace H_113_InsertMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //Insert
            myList.Insert(2, 25);

            Console.WriteLine("Demonstrating Insert method in List");
            foreach (int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
