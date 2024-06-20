using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tuple Example
namespace H_156_Tuple
{
    class Sample
    {
        //return type as tuple
        public Tuple<string,int> GetPersonDetails()
        {
            //create new tuple that stores person name and age
            Tuple<string, int> person = new Tuple<string, int>("Vicky", 27);

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple
            Tuple<string, int> person = new Tuple<string, int>("Ranjeet",29);

            //access tuple value
            Console.WriteLine(person.Item1);    //ranjeet
            Console.WriteLine(person.Item2);    //29

            Console.WriteLine();

            //sample class object
            Sample s = new Sample();
            Tuple<string, int> pm = s.GetPersonDetails();

            Console.WriteLine(pm.Item1);
            Console.WriteLine(pm.Item2);

            Console.ReadLine();
        }
    }
}
