using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add method in collection Example
namespace H_111_AddMethodCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //add new element in the collection
            myList.Add(40);

            Console.WriteLine("Demonstrating Add method in List");
            foreach(int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
