using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Static class Example
namespace _63_StaticClassExample
{
    //Static class
    public static class Country
    {
        //static fields
        public static string CountryName = "India";
        public static int noOfStates = 28;

        
        //Static methods
        public static int GetNoOfUTs()
        {
            return 8;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //accessing static fields and methods
            Console.WriteLine(Country.CountryName);
            Console.WriteLine(Country.noOfStates);
            Console.WriteLine(Country.GetNoOfUTs());

            Console.ReadKey();
        }
    }
}
