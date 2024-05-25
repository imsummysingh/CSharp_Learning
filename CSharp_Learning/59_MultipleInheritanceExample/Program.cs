using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Multiple Inheritance Example with Interface
namespace _59_MultipleInheritanceExample
{
    //Parent Interface 1
    interface IParent1
    {
        string Parent1Message();
    }

    //Parent Interface 2
    interface IParent2
    {
        string Parent2Message();
    }

    //Child class
    class Child : IParent1, IParent2
    {
        public string Parent1Message()
        {
            return "Message from Parent 1 Method Implementation";
        }

        public string Parent2Message()
        {
            return "Message from Parent 2 method Implementation";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Creating reference variable for the parent
            IParent1 p1;
            IParent2 p2;

            //Creating object for the child class
            p1 = new Child();
            Console.WriteLine(p1.Parent1Message());

            p2 = new Child();
            Console.WriteLine(p2.Parent2Message());

            Console.ReadLine();
        }
    }
}
