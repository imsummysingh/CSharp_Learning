using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find Index method in collection example
namespace H_129_FindIndexMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<int> marks = new List<int>() { 34, 45, 67, 78, 23 };

            //Find Index method
            int index = marks.FindIndex(m => m <= 33);

            Console.WriteLine("Index is:" + index);

            Console.ReadLine();
        }
    }
}
