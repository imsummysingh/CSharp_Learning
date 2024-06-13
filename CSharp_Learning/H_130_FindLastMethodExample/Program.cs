using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Find Last method in collection example
namespace H_130_FindLastMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 7, 80, 90 };

            //FindLast  ->returns the last element that satisfy the lambda expression condition.
            int element = myList.FindLast(i => i <= 50);
            Console.WriteLine(element);

            Console.ReadLine();
        }
    }
}
