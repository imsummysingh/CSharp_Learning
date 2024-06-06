using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Understanding Structure And Class
namespace _67_StructureAndClass
{
    //Structure
    public struct Structure1
    {
        //fields
        public int x, y;
    }


    //Class
    public class Class1
    {
        //fields
        public int x, y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating structure Instance without 'new' keyword, because it is not required when initializing the fields manually.
            Structure1 s;
            s.x = 10;
            s.y = 20;

            //Creating object of the class
            //Creating reference variable which will store ->null by default
            Class1 c;
            //creating object with the reference variable and the default value for the int fields will be 0 and stored in heap
            c = new Class1();
            c.x = 100; //Changing default value of x from 0 to 100
            c.y = 200;


            //Creating instance 2 of structure
            Structure1 s2 = new Structure1();
            //copy data from structure1 to structure 2
            s2 = s; //->so, a will be 10, and y will be 20

            //modify value of structure 2
            //-> This will not change the value of structure 1 and it will only modify the value of structure 2
            s2.x = 101;
            s2.y = 201;


            //Creating another reference variable for class
            Class1 c2;

            //copy reference from c1 to c2
            c2 = c; //->It will now point to the same heap because the reference variable hold the same address

            //try to modify the value of c1 from reference variable c2
            //This will modify the value of the C1 also with the modified value of c2.
            c2.x = 10;
            c2.y = 20;


            Console.WriteLine("Value of structure 1:");
            Console.WriteLine("X:"+s.x);
            Console.WriteLine("Y"+s.y);
            Console.WriteLine();
            Console.WriteLine("Value of structure 2:");
            Console.WriteLine("X:"+s2.x);
            Console.WriteLine("Y:"+s2.y);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Value of Class 1:");
            Console.WriteLine("X:" + c.x);
            Console.WriteLine("Y" + c.y);
            Console.WriteLine();
            Console.WriteLine("Value of Class 2:");
            Console.WriteLine("X:" + c2.x);
            Console.WriteLine("Y:" + c2.y);


            Console.ReadLine();
        }
    }
}
