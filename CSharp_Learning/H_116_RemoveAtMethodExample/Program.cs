using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//RemoveAt Method in collection
namespace H_116_RemoveAtMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 20, 30, 35, 40, 50, 60 };

            //rRemoveAt ->For specified index.
            myList.RemoveAt(3);     //removing 35 at index 3

            Console.WriteLine("Demonstrating RemoveAt method in List");
            foreach (int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
