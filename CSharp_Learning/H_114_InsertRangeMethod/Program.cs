using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Insert Range Method Example
namespace H_114_InsertRangeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //Insert Range

            //way1
            List<int> otherList = new List<int>() { 22, 23, 24, 25, 26 };
            myList.InsertRange(2,otherList);

            //way 2
            myList.InsertRange(0, new List<int>() { 2, 4, 6, 8 });

            Console.WriteLine("Demonstrating Insert Range method in List");
            foreach (int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
