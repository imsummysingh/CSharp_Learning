using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Indexer Example
namespace _47_Indexer
{
    class Car
    {
        //private field
        private string[] _brands = new string[] { "BMW", "Honda", "Skoda" };

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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();

            //calling get accessor
            Console.WriteLine(c[0]);      //BMW

            c[0] = "Ferrari";       //overriding the value
            Console.WriteLine(c[0]);    //Ferrari

            Console.ReadLine();
        }
    }
}
