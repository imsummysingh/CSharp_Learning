using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pattern Matching Example
namespace _78_PattenMatchingExample
{
    //parent class
    class ParentClass
    {
        public int x { get; set; }
    }

    //child class
    class ChildClass:ParentClass
    {
        public int y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //reference variable of parent class
            ParentClass pc;

            //pbject of child class
            pc = new ChildClass() { x = 10, y = 20 };

            //can only access parent class member
            Console.WriteLine(pc.x);

            //We cannot ACCESS child class member with parent class refering to the child class object, because then we will only be able to access parent class member
            //But we want to access the child class member, So we will have to typecast the parent class's reference variable into the child class reference variable.
            
            //1. CLassical way
            //if(pc is ChildClass)
            //{
            //    ChildClass cc = (ChildClass)pc;
            //    Console.WriteLine(cc.x);
            //    Console.WriteLine(cc.y);
            //}

            //2. Pattern Matching
            if(pc is ChildClass cc)
            {
                Console.WriteLine(cc.x);
                Console.WriteLine(cc.y);
            }


            Console.ReadLine();
        }
    }
}
