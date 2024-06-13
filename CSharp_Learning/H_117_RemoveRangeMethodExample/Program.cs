using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Remove Range method example in collection
namespace H_117_RemoveRangeMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating collection
            List<int> myList = new List<int>(10) { 10, 20, 30, 32, 34, 36, 38, 40, 50, 60 };

            //RemoveRange ->Start index, count
            myList.RemoveRange(3, 4);   //32,34,36,38

            Console.WriteLine("Demonstrating RemoveRange method in List");
            foreach (int el in myList)
            {
                Console.WriteLine(el);
            }
            Console.ReadLine();
        }
    }
}
