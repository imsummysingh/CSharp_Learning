using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add Range Method in Collection
namespace H_112_AddRangeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //add new element in the collection
            myList.Add(40);

            //Another collection
            List<int> otherList = new List<int>() { 50, 60, 70 };

            //Add Range
            myList.AddRange(otherList);
            myList.AddRange(new List<int>() { 80, 90, 100 });

            Console.WriteLine("Demonstrating Add method in List");
            foreach (int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
