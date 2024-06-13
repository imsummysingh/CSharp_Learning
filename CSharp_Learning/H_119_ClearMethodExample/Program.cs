using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clear method example in collection
namespace H_119_ClearMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 11, 13, 17, 20, 23, 27, 30, 33, 35, 36, 39, 40, 50, 60 };

            //Clear method-> Clear the entire list.
            myList.Clear();

            Console.WriteLine("Demonstrating Clear method in List");
            foreach (int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("Skipped the loop because list is Clear");
            Console.ReadLine();
        }
    }
}
