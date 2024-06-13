using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Sort Method in collection
namespace H_123_SortMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list
            List<int> myList = new List<int>() { 12,424,534,22,9,43,123,89 };

            Console.WriteLine("Original List");
            foreach(int li in myList)
            {
                Console.Write(li + " ");
            }
            Console.WriteLine();
            
            //sort method
            myList.Sort();
            Console.WriteLine("Sorted List");
            foreach (int li in myList)
            {
                Console.Write(li + " ");
            }

            Console.ReadLine();
        }
    }
}
