using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stack Example
namespace H_139_Stack
{
    class Student
    {
        public int Marks { get; set; }
        public int Rank { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create object of stack
            Stack<int> marks = new Stack<int>();

            //add
            marks.Push(45);
            marks.Push(61);
            marks.Push(80);
            marks.Push(93);

            //foreach for accesing the stack
            Console.WriteLine("Pushing values in stack");
            foreach (int item in marks)
            {
                Console.WriteLine(item);
            }


            //remove
            marks.Pop();
            marks.Pop();
            Console.WriteLine("After removing last 2 elements");
            foreach (int item in marks)
            {
                Console.WriteLine(item);
            }

            //peek
            Console.WriteLine("Peek: " + marks.Peek());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Create student type object of stack
            Stack<Student> stu = new Stack<Student>();

            //add
            stu.Push(new Student() { Marks = 45 });
            stu.Push(new Student() { Marks = 81 });
            stu.Push(new Student() { Marks = 89 });

            Console.WriteLine("Student Type Object with Stack");

            //accesing the value
            int r = 1;
            foreach(Student s in stu)
            {
                s.Rank = r;
                Console.WriteLine(s.Marks +" , "+s.Rank);
                r++;
            }

            


            Console.ReadLine();
        }
    }
}
