using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ForEach() method in collection Example.
namespace H_126_ForEachMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<string> myFriends = new List<string>() { "Ranjeet", "Vicky", "Vishal", "Mani", "Piyush" };

            //ForEach method
            myFriends.ForEach(frnd => Console.WriteLine(frnd));

            Console.ReadLine();
        }
    }
}
