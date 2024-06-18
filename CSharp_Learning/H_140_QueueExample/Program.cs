using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Queue Example
namespace H_140_QueueExample
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
            Queue<int> marks = new Queue<int>();

            //add
            marks.Enqueue(45);
            marks.Enqueue(61);
            marks.Enqueue(80);
            marks.Enqueue(93);

            //foreach for accesing the stack
            Console.WriteLine("Enqueue(Insert) values in Queue");
            foreach (int item in marks)
            {
                Console.WriteLine(item);
            }


            //remove
            marks.Dequeue();
            marks.Dequeue();
            Console.WriteLine("After removing first 2 elements");
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
            Queue<Student> stu = new Queue<Student>();

            //add
            stu.Enqueue(new Student() { Marks = 45 });
            stu.Enqueue(new Student() { Marks = 81 });
            stu.Enqueue(new Student() { Marks = 89 });

            Console.WriteLine("Student Type Object with Stack");

            //accesing the value
            int r = 1;
            foreach (Student s in stu)
            {
                s.Rank = r;
                Console.WriteLine(s.Marks + " , " + s.Rank);
                r++;
            }




            Console.ReadLine();
        }
    }
}
