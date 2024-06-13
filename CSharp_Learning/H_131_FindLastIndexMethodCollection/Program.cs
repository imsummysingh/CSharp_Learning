using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find Last Index Method in collection Example
namespace H_131_FindLastIndexMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 7, 80, 90 };

            //FindLastIndex  ->returns the last element's Index that satisfy the lambda expression condition.
            int elementIndex = myList.FindLastIndex(i => i <= 50);
            Console.WriteLine(elementIndex);

            Console.ReadLine();
        }
    }
}
