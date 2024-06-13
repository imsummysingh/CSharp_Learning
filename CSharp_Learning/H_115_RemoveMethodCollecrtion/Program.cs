using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Remove Method Example in Collection
namespace H_115_RemoveMethodCollecrtion
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            //Remove ->Provide value and not index
            myList.Remove(20);      //remove 20

            Console.WriteLine("Demonstrating Remove method in List");
            foreach (int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
