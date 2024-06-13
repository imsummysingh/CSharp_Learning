using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ToArray() method example in collection.
namespace H_125_ToArrayMethodCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<string> myFriends = new List<string>() { "Ranjeet", "Vicky", "Vishal", "Mani", "Piyush" };

            //converting list to an array
            ////->It will create corresponding of that data type which was used in the List. 
            /////assigning the reference of the array in the reference variable.
            string[] frnds = myFriends.ToArray();

            //display value of array
            foreach (string i in frnds)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
