using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Nullable Example.
namespace _75_NullableExample
{
    class Person
    {
        //public int NoOfChildren;

        //Converting the field into nullable type, so we can store null in the int data type which is non-nullable
        public int? NoOfChildren;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create object
            Person p1 = new Person() { NoOfChildren = 2 };

            //will throw compile error: Cannot convert null to int because it is non-nullable type.
            //Person p2 = new Person() { NoOfChildren = null };

            //After conversion, calling it again with null value.
            Person p2 = new Person() { NoOfChildren = null };

            Console.WriteLine(p1.NoOfChildren);
            Console.WriteLine(p2.NoOfChildren);
            Console.WriteLine();
            Console.WriteLine();

            //Null coalescing operator 
            Person p3 = new Person() { NoOfChildren = 5 };
            Person p4 = new Person() { NoOfChildren = null };

            Console.WriteLine("Null coalescing operator");
            Console.WriteLine(p3.NoOfChildren ?? 0);    //5
            Console.WriteLine(p4.NoOfChildren ?? 6);    //6

            Console.ReadLine();


        }
    }
}
