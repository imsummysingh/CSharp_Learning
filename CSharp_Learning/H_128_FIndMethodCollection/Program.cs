using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Find method in collection example
namespace H_128_FIndMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<int> marks = new List<int>() { 34, 45, 67, 78, 23 };

            //Find method
            int mark = marks.Find(m=>m<=33);

            Console.WriteLine("Least scored mark is:"+mark);

            Console.ReadLine();
        }
    }
}
