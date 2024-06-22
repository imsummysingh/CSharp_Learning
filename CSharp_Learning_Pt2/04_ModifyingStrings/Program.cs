using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Modifying Strings example
namespace _04_ModifyingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "Hypo";

            //insert method
            string newMsg = msg.Insert(4,"thesis");

            Console.WriteLine(newMsg);  //Hypothesis


            //Remove method
            string m = "Hypothesis";
            string nm = m.Remove(4, 6);
            Console.WriteLine(nm);  //Hypo


            Console.ReadLine();
        }
    }
}
