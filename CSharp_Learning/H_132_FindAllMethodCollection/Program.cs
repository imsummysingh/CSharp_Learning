using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find All method Example
namespace H_132_FindAllMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 7, 80, 90 };

            //FindAll
            List<int> elements = myList.FindAll(i => i <= 50);
            foreach(int i in elements)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
