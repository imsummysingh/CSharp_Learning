using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Reverse Method in collection example
namespace H_124_ReverseMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            Console.WriteLine("Original List");
            foreach(int i in myList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //reverse method
            myList.Reverse();
            
            Console.WriteLine("Reversed list");
            foreach(int i in myList)
            {
                Console.Write(i + " ");
            }


            Console.ReadLine();
        }
    }
}
