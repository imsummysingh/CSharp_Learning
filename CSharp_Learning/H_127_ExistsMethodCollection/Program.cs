using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Exists method example in collection
namespace H_127_ExistsMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int>() { 34, 45, 67, 78, 23 };

            //Exists method -> CHeck is student is failed
            //This condition will be checked for each element in the list collection.
            bool b = marks.Exists(m => m <= 33);

            if (b == true)
            {
                Console.WriteLine("Student is Failed!");
            }
            else
            {
                Console.WriteLine("Student is Passed.");
            }

            Console.ReadLine();
        }
    }
}
