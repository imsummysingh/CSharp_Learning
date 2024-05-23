using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Indexer Overloading Example
namespace _48_IndexerOverloading
{
    class Car
    {
        //private field 
        private string[] _brands = new string[] { "BMW", "Honda", "Skoda" };
        private string[] _names = new string[] { "first", "second", "third" };

        //public Indexer
        public string this[int index]
        {
            set
            {
                this._brands[index] = value;
            }
            get
            {
                return _brands[index];
            }
        }

        //another indexer for Indexer Overloading
        public string this[string name]
        {
            set
            {
                this._brands[Array.IndexOf(_names, name)] = value;
            }
            get
            {
                return _brands[Array.IndexOf(_names, name)];
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            //calling get accessor
            //We will get the same value as BMW in both the way of calling the indexer, because we overloaded the indexer.
            Console.WriteLine(c[0]);      //BMW
            Console.WriteLine(c["first"]);    //BMW


            c[0] = "Ferrari";       //overriding the value
            Console.WriteLine(c[0]);    //Ferrari

            Console.ReadLine();
        }
    }
}
