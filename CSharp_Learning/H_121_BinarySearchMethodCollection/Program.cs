using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//BinarySearch Method Example in collection
namespace H_121_BinarySearchMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            //Binary Search
            myList.BinarySearch(30);

            Console.WriteLine("Index:" + myList.BinarySearch(30));

            Console.ReadLine();
        }
    }
}
