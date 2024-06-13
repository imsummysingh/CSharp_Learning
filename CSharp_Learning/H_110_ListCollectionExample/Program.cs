using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//List collection Example
namespace H_110_ListCollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create reference variable for List class
            List<int> myList;
            //create object of list class
            myList = new List<int>() { 10, 20, 30 };

            //read element using foreach
            //foreach(int item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //read element using for loop
            for(int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);   //10,20,30
            }

            Console.ReadLine();
        }
    }
}
