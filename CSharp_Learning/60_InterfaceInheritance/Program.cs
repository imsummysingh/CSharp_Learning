using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface Inheritance Example
namespace _60_InterfaceInheritance
{
    //Interface 1
    interface Iparent1
    {
        //method of interface
        string Parent1Method();
    }

    //interface 2
    interface Iparent2
    {
        //method 1 of interface 2
        string Parent2Method1();

        //method 2 of interface 2
        string Parent2Method2();
    }

    //child class will implement all the methods of Interface 1 & 2
    class Child : Iparent1, Iparent2
    {
        public string Parent1Method()
        {
            return "Method 1 of Interface 1 is called";
        }

        public string Parent2Method1()
        {
            return "Method 1 of Interface 2 is called";
        }

        public string Parent2Method2()
        {
            return "Method 2 of Interface 2 is Called";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating reference variable for the interfaces
            Iparent1 p1;
            Iparent2 p2;

            //Creating obj for Interface 1
            p1 = new Child();
            Console.WriteLine(p1.Parent1Method());

            //creating obj for Interface 2
            p2 = new Child();
            Console.WriteLine(p2.Parent2Method1());
            Console.WriteLine(p2.Parent2Method2());

            Console.ReadLine();

        }
    }
}
